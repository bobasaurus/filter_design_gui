using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NWaves;
using NWaves.Signals;
using System.Diagnostics;

namespace filter_design_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxWindow.Items.AddRange(new string[]
            {
                "BartlettHann",
                "Bartlett",
                "BlackmanHarris",
                "BlackmanNuttall",
                "Blackman",
                "Cosine",
                "FlatTop",
                "Gauss",
                "Hamming",
                "Hann",
                "Lanczos",
                "Nuttall",
                "Rectangular",
                "Triangular"
            });
            comboBoxWindow.SelectedIndex = Properties.Settings.Default.windowIndex;
        }

        private MathNet.Filtering.Windowing.Window GetWindowFromString(string value, double gaussSigma)
        {
            switch (value)
            {
                case "BartlettHann":
                    return new MathNet.Filtering.Windowing.BartlettHannWindow();
                case "Bartlett":
                    return new MathNet.Filtering.Windowing.BartlettWindow();
                case "BlackmanHarris":
                    return new MathNet.Filtering.Windowing.BlackmanHarrisWindow();
                case "BlackmanNuttall":
                    return new MathNet.Filtering.Windowing.BlackmanNuttallWindow();
                case "Blackman":
                    return new MathNet.Filtering.Windowing.BlackmanWindow();
                case "Cosine":
                    return new MathNet.Filtering.Windowing.CosineWindow();
                case "FlatTop":
                    return new MathNet.Filtering.Windowing.FlatTopWindow();
                case "Gauss":
                    return new MathNet.Filtering.Windowing.GaussWindow(gaussSigma);
                case "Hamming":
                    return new MathNet.Filtering.Windowing.HammingWindow();
                case "Hann":
                    return new MathNet.Filtering.Windowing.HannWindow();
                case "Lanczos":
                    return new MathNet.Filtering.Windowing.LanczosWindow();
                case "Nuttall":
                    return new MathNet.Filtering.Windowing.NuttallWindow();
                case "Rectangular":
                    return new MathNet.Filtering.Windowing.RectangularWindow();
                case "Triangular":
                    return new MathNet.Filtering.Windowing.TriangularWindow();
            }
            return null;
        }

        private Random random = new Random();

        private void UpdateFilter(double sampleRate, double[] coeffs, string name)
        {
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            labelCoeffs.Text = "Coeffs (" + coeffs.Length + " point kernel):";

            //array of times for the time-domain plots
            double[] xTimeRange = new double[coeffs.Length];
            
            richTextBoxCoeffs.Clear();
            for (int i = 0; i < coeffs.Length; i++)
            {
                richTextBoxCoeffs.AppendText(string.Format("{0}" + Environment.NewLine, coeffs[i]));
                xTimeRange[i] = ((double)i) / sampleRate;//s
            }

            ZedGraph.PointPairList ppl = new ZedGraph.PointPairList(xTimeRange, coeffs);
            var curve = zgcImpulseResponse.GraphPane.AddCurve(name, ppl, randomColor);
            curve.Symbol.Type = ZedGraph.SymbolType.Circle;
            curve.Symbol.Size = 5;
            curve.Symbol.Fill = new ZedGraph.Fill(curve.Color);
            curve.Line.Width = 1;

            zgcImpulseResponse.GraphPane.Title.IsVisible = false;
            zgcImpulseResponse.GraphPane.XAxis.Title.Text = "Time [s]";
            zgcImpulseResponse.GraphPane.YAxis.Title.Text = "Amplitude";
            //zgcImpulseResponse.GraphPane.Legend.IsVisible = false;
            zgcImpulseResponse.GraphPane.XAxis.Scale.Min = xTimeRange.First();
            zgcImpulseResponse.GraphPane.XAxis.Scale.Max = xTimeRange.Last();

            zgcImpulseResponse.AxisChange();
            zgcImpulseResponse.Refresh();

            int fftSize = 8192;
            int fftOrder = (int)Math.Log(fftSize, 2);
            if (Math.Pow(2, fftOrder) != fftSize) throw new Exception("darn");
            double[] real, imag;
            
            //real = Enumerable.Repeat<double>(0, fftSize).ToArray();
            //Array.Copy(coeffs, 0, real, 0, coeffs.Length);
            //imag = Enumerable.Repeat<double>(0, fftSize).ToArray();
            //MathNet.Numerics.IntegralTransforms.Fourier.Forward(real, imag);

            NAudio.Dsp.Complex[] data = new NAudio.Dsp.Complex[fftSize];
            for (int i=0; i<fftSize; i++)
            {
                if (i < coeffs.Length)
                {
                    data[i].X = (float)coeffs[i];
                    data[i].Y = 0;
                }
                else//maybe redundant
                {
                    data[i].X = 0;
                    data[i].Y = 0;
                }
            }
            NAudio.Dsp.FastFourierTransform.FFT(true, fftOrder, data);
            real = (from d in data select (double)d.X).ToArray();
            imag = (from d in data select (double)d.Y).ToArray();
            //MathNet.Numerics.IntegralTransforms.Fourier.Forward(real, imag);


            List<double> powers = new List<double>();
            List<double> freqs = new List<double>();
            double frequencyResolution = sampleRate / fftSize;
            double currentFrequency = 0;
            for (int i = 0; i < fftSize/2; i++)
            {
                currentFrequency = ((double)i) / (fftSize / 2) * (sampleRate / 2);
                powers.Add(Math.Log10(real[i] * real[i] + imag[i] * imag[i]) * 10);
                freqs.Add(currentFrequency);
                //currentFrequency += frequencyResolution;
            }

            ZedGraph.PointPairList pplFreq = new ZedGraph.PointPairList(freqs.ToArray(), powers.ToArray());
            curve = zgcFrequencyResponse.GraphPane.AddCurve(name, pplFreq, randomColor);
            curve.Symbol.Type = ZedGraph.SymbolType.Circle;
            curve.Symbol.Size = 5;
            curve.Symbol.Fill = new ZedGraph.Fill(curve.Color);
            curve.Line.Width = 1;

            zgcFrequencyResponse.GraphPane.Title.IsVisible = false;
            zgcFrequencyResponse.GraphPane.XAxis.Title.Text = "Frequency [Hz]";
            zgcFrequencyResponse.GraphPane.YAxis.Title.Text = "Power [dB]";
            //zgcFrequencyResponse.GraphPane.Legend.IsVisible = false;
            zgcFrequencyResponse.GraphPane.XAxis.Scale.Min = freqs.First();
            zgcFrequencyResponse.GraphPane.XAxis.Scale.Max = freqs.Last();

            zgcFrequencyResponse.AxisChange();
            zgcFrequencyResponse.Refresh();

            //save the window selection to the properties.settings (other settings are saved using property bindings)
            if ((comboBoxWindow.SelectedIndex >= 0) && (comboBoxWindow.SelectedIndex < comboBoxWindow.Items.Count))
                Properties.Settings.Default.windowIndex = comboBoxWindow.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void ButtonLP_Click(object sender, EventArgs e)
        {
            try
            {
                double sampleRate = double.Parse(textBoxSampleRate.Text);
                double cutoffFreq = double.Parse(textBoxCutoffFrequency.Text);
                int filterLength = int.Parse(textBoxFilterLength.Text);
                //only used for the Gauss window
                double gaussSigma = double.Parse(textBoxGaussSigma.Text);

                var windowStr = comboBoxWindow.Text;
                var window = GetWindowFromString(windowStr, gaussSigma);
                if (window == null) throw new Exception("Unable to determine window type");

                double[] coeffs = FilterCalc.CalcLowpassFilterMathDotNet(sampleRate, cutoffFreq, filterLength, window);

                string name = string.Format("M.N LP, SR: {0:0.}, Fc: {1:0.0}, " + windowStr, sampleRate, cutoffFreq);
                UpdateFilter(sampleRate, coeffs, name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            var text = richTextBoxCoeffs.Text.Trim();
            Clipboard.SetText(text);
        }

        private void ButtonCopyCSV_Click(object sender, EventArgs e)
        {
            var text = richTextBoxCoeffs.Text.Trim();
            text = text.Replace("\n", ",\n");
            if (text.EndsWith(","))
                text = text.Remove(text.Length - 1, 1);
            Clipboard.SetText(text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            zgcFrequencyResponse.GraphPane.GraphObjList.Clear();
            zgcFrequencyResponse.GraphPane.CurveList.Clear();
            zgcFrequencyResponse.Refresh();
            zgcImpulseResponse.GraphPane.GraphObjList.Clear();
            zgcImpulseResponse.GraphPane.CurveList.Clear();
            zgcImpulseResponse.Refresh();
        }
    }
}
