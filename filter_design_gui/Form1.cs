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

        private NWaves.Windows.WindowTypes GetNWavesWindowFromString(string value)
        {
            //NOTE: there are more options available in NWaves, maybe make them available in GUI someday
            switch (value)
            {
                case "BartlettHann":
                    return NWaves.Windows.WindowTypes.BartlettHann;
                case "Blackman":
                    return NWaves.Windows.WindowTypes.Blackman;
                case "FlatTop":
                    return NWaves.Windows.WindowTypes.Flattop;
                case "Gauss":
                    return NWaves.Windows.WindowTypes.Gaussian;
                case "Hamming":
                    return NWaves.Windows.WindowTypes.Hamming;
                case "Hann":
                    return NWaves.Windows.WindowTypes.Hann;
                case "Lanczos":
                    return NWaves.Windows.WindowTypes.Lanczos;
                case "Rectangular":
                    return NWaves.Windows.WindowTypes.Rectangular;
                case "Triangular":
                    return NWaves.Windows.WindowTypes.Triangular;
                default:
                    throw new Exception("Invalid window type for NWaves: " + value);
            }
        }

        private MathNet.Filtering.Windowing.Window GetMathNETWindowFromString(string value, double gaussSigma)
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

        private void UpdateFilterResults(double sampleRate, double[] coeffs, string name)
        {
            UpdateFilterResults(sampleRate, coeffs, name, double.NaN, double.NaN);
        }
        private void UpdateFilterResults(double sampleRate, double[] coeffs, string name, double Fc1, double Fc2)
        {
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            //make the graph symbol size grow with the number of overplotted curves so all are visible if they overlap
            int symbolSize = zgcFrequencyResponseLog.GraphPane.CurveList.Count() + 4;

            //show the number of filter coeffs on the GUI label
            labelCoeffs.Text = "Coeffs (" + coeffs.Length + " point kernel):";

            //array of times for the time-domain plots
            double[] xTimeRange = new double[coeffs.Length];//s
            //array for the step response results (integrating the impulse response)
            double[] stepResponseArray = new double[coeffs.Length];
            double stepResponseIntegration = 0;
            
            //show the coeffs on the text box, and calculate the x time range for plotting
            richTextBoxCoeffs.Clear();
            for (int i = 0; i < coeffs.Length; i++)
            {
                richTextBoxCoeffs.AppendText(string.Format("{0}" + Environment.NewLine, coeffs[i]));
                xTimeRange[i] = ((double)i) / sampleRate;//s
                stepResponseIntegration += coeffs[i];
                stepResponseArray[i] = stepResponseIntegration;
            }

            //create the time-based plots
            ZedGraph.LineItem curve;
            //impulse response plot:
            ZedGraph.PointPairList ppl = new ZedGraph.PointPairList(xTimeRange, coeffs);
            curve = zgcImpulseResponse.GraphPane.AddCurve(name, ppl, randomColor);
            curve.Symbol.Type = ZedGraph.SymbolType.Circle;
            curve.Symbol.Size = symbolSize;
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

            //step response plot:
            ZedGraph.PointPairList pplStep = new ZedGraph.PointPairList(xTimeRange, stepResponseArray);
            curve = zgcStepResponse.GraphPane.AddCurve(name, pplStep, randomColor);
            curve.Symbol.Type = ZedGraph.SymbolType.Circle;
            curve.Symbol.Size = symbolSize;
            curve.Symbol.Fill = new ZedGraph.Fill(curve.Color);
            curve.Line.Width = 1;
            zgcStepResponse.GraphPane.Title.IsVisible = false;
            zgcStepResponse.GraphPane.XAxis.Title.Text = "Time [s]";
            zgcStepResponse.GraphPane.YAxis.Title.Text = "Amplitude";
            //zedGraphControlStepResponse.GraphPane.Legend.IsVisible = false;
            zgcStepResponse.GraphPane.XAxis.Scale.Min = xTimeRange.First();
            zgcStepResponse.GraphPane.XAxis.Scale.Max = xTimeRange.Last();
            zgcStepResponse.AxisChange();
            zgcStepResponse.Refresh();

            //setup the FFT
            int fftSize = 32768;
            int fftOrder = (int)Math.Log(fftSize, 2);
            if (Math.Pow(2, fftOrder) != fftSize) throw new Exception("darn");
            
            float[] real = new float[fftSize];
            float[] imag = new float[fftSize];
            for (int i=0; i<coeffs.Length; i++)
            {
                real[i] = (float)coeffs[i];
                imag[i] = 0;
            }
            NWaves.Transforms.Fft fft = new NWaves.Transforms.Fft(fftSize);
            fft.Direct(real, imag);

            List<double> amplitudes = new List<double>();
            List<double> powers = new List<double>();
            List<double> freqs = new List<double>();
            for (int i = 0; i < fftSize/2; i++)
            {
                double frequency = ((double)i) / (fftSize / 2) * (sampleRate / 2);
                freqs.Add(frequency);

                double amplitude = Math.Sqrt(real[i] * real[i] + imag[i] * imag[i]);
                amplitudes.Add(amplitude);

                double power = 10 * Math.Log10(amplitude);
                powers.Add(power);
            }

            //frequency response log plot:
            ZedGraph.PointPairList pplFreq = new ZedGraph.PointPairList(freqs.ToArray(), powers.ToArray());
            curve = zgcFrequencyResponseLog.GraphPane.AddCurve(name, pplFreq, randomColor);
            curve.Symbol.Type = ZedGraph.SymbolType.Circle;
            curve.Symbol.Size = symbolSize;
            curve.Symbol.Fill = new ZedGraph.Fill(curve.Color);
            curve.Line.Width = 1;
            zgcFrequencyResponseLog.GraphPane.Title.IsVisible = false;
            zgcFrequencyResponseLog.GraphPane.XAxis.Title.Text = "Frequency [Hz]";
            zgcFrequencyResponseLog.GraphPane.YAxis.Title.Text = "Power [dB]";
            zgcFrequencyResponseLog.GraphPane.XAxis.Scale.Min = freqs.First();
            zgcFrequencyResponseLog.GraphPane.XAxis.Scale.Max = freqs.Last();
            if (!double.IsNaN(Fc1))
            {
                double centerLineX = Fc1;
                if (double.IsNaN(centerLineX)) centerLineX = 0;
                var centerLine = new ZedGraph.LineObj(centerLineX, 0, centerLineX, 1);
                centerLine.Location.CoordinateFrame = ZedGraph.CoordType.XScaleYChartFraction;
                centerLine.Line.Width = 1;
                centerLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;
                centerLine.Line.Color = Color.Gray;
                zgcFrequencyResponseLog.GraphPane.GraphObjList.Add(centerLine);
            }
            if (!double.IsNaN(Fc2))
            {
                double centerLineX = Fc2;
                if (double.IsNaN(centerLineX)) centerLineX = 0;
                var centerLine = new ZedGraph.LineObj(centerLineX, 0, centerLineX, 1);
                centerLine.Location.CoordinateFrame = ZedGraph.CoordType.XScaleYChartFraction;
                centerLine.Line.Width = 1;
                centerLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;
                centerLine.Line.Color = Color.Gray;
                zgcFrequencyResponseLog.GraphPane.GraphObjList.Add(centerLine);
            }
            zgcFrequencyResponseLog.AxisChange();
            zgcFrequencyResponseLog.Refresh();

            //frequency response linear plot:
            ZedGraph.PointPairList pplFreqLinear = new ZedGraph.PointPairList(freqs.ToArray(), amplitudes.ToArray());
            curve = zgcFrequencyResponseLinear.GraphPane.AddCurve(name, pplFreqLinear, randomColor);
            curve.Symbol.Type = ZedGraph.SymbolType.Circle;
            curve.Symbol.Size = symbolSize;
            curve.Symbol.Fill = new ZedGraph.Fill(curve.Color);
            curve.Line.Width = 1;
            zgcFrequencyResponseLinear.GraphPane.Title.IsVisible = false;
            zgcFrequencyResponseLinear.GraphPane.XAxis.Title.Text = "Frequency [Hz]";
            zgcFrequencyResponseLinear.GraphPane.YAxis.Title.Text = "Amplitude";
            zgcFrequencyResponseLinear.GraphPane.XAxis.Scale.Min = freqs.First();
            zgcFrequencyResponseLinear.GraphPane.XAxis.Scale.Max = freqs.Last();
            if (!double.IsNaN(Fc1))
            {
                double centerLineX = Fc1;
                if (double.IsNaN(centerLineX)) centerLineX = 0;
                var centerLine = new ZedGraph.LineObj(centerLineX, 0, centerLineX, 1);
                centerLine.Location.CoordinateFrame = ZedGraph.CoordType.XScaleYChartFraction;
                centerLine.Line.Width = 1;
                centerLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;
                centerLine.Line.Color = Color.Gray;
                zgcFrequencyResponseLinear.GraphPane.GraphObjList.Add(centerLine);
            }
            if (!double.IsNaN(Fc2))
            {
                double centerLineX = Fc2;
                if (double.IsNaN(centerLineX)) centerLineX = 0;
                var centerLine = new ZedGraph.LineObj(centerLineX, 0, centerLineX, 1);
                centerLine.Location.CoordinateFrame = ZedGraph.CoordType.XScaleYChartFraction;
                centerLine.Line.Width = 1;
                centerLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;
                centerLine.Line.Color = Color.Gray;
                zgcFrequencyResponseLinear.GraphPane.GraphObjList.Add(centerLine);
            }
            zgcFrequencyResponseLinear.AxisChange();
            zgcFrequencyResponseLinear.Refresh();

            //save the window selection to the properties.settings (other settings are saved using property bindings)
            if ((comboBoxWindow.SelectedIndex >= 0) && (comboBoxWindow.SelectedIndex < comboBoxWindow.Items.Count))
                Properties.Settings.Default.windowIndex = comboBoxWindow.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void ButtonLPMathNET_Click(object sender, EventArgs e)
        {
            try
            {
                double sampleRate = double.Parse(textBoxSampleRate.Text);
                double cutoffFreq1 = double.Parse(textBoxCutoffFrequency1.Text);

                int filterLength = int.Parse(textBoxFilterLength.Text);
                //only used for the Gauss window
                double gaussSigma = double.Parse(textBoxGaussSigma.Text);

                var windowStr = comboBoxWindow.Text;
                var window = GetMathNETWindowFromString(windowStr, gaussSigma);
                if (window == null) throw new Exception("Unable to determine window type");

                double[] coeffs = FilterCalc.CalcLowpassFilterMathDotNet(sampleRate, cutoffFreq1, filterLength, window);

                string name = string.Format("Math.NET LP, SR: {0:0.}, Fc: {1:0.0}, " + windowStr, sampleRate, cutoffFreq1);
                UpdateFilterResults(sampleRate, coeffs, name, cutoffFreq1, double.NaN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonLPNWaves_Click(object sender, EventArgs e)
        {
            try
            {
                double sampleRate = double.Parse(textBoxSampleRate.Text);
                double cutoffFreq1 = double.Parse(textBoxCutoffFrequency1.Text);

                int filterLength = int.Parse(textBoxFilterLength.Text);

                var windowStr = comboBoxWindow.Text;
                var window = GetNWavesWindowFromString(windowStr);

                double[] coeffs = FilterCalc.CalcLowpassFilterNWaves(sampleRate, cutoffFreq1, filterLength, window);

                string name = string.Format("NWaves LP, SR: {0:0.}, Fc: {1:0.0}, " + windowStr, sampleRate, cutoffFreq1);
                UpdateFilterResults(sampleRate, coeffs, name, cutoffFreq1, double.NaN);
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
            ClearZGC(zgcFrequencyResponseLog);
            ClearZGC(zgcFrequencyResponseLinear);
            ClearZGC(zgcImpulseResponse);
            ClearZGC(zgcStepResponse);
        }
        private void ClearZGC(ZedGraph.ZedGraphControl zgc)
        {
            zgc.GraphPane.GraphObjList.Clear();
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.XAxis.Scale.MinAuto = true;
            zgc.GraphPane.XAxis.Scale.MaxAuto = true;
            zgc.GraphPane.YAxis.Scale.MinAuto = true;
            zgc.GraphPane.YAxis.Scale.MaxAuto = true;
            zgc.GraphPane.Y2Axis.Scale.MinAuto = true;
            zgc.GraphPane.Y2Axis.Scale.MaxAuto = true;
            zgc.Refresh();
        }

        private void ButtonBPMathNET_Click(object sender, EventArgs e)
        {
            try
            {
                double sampleRate = double.Parse(textBoxSampleRate.Text);
                double cutoffFreq1 = double.Parse(textBoxCutoffFrequency1.Text);
                double cutoffFreq2 = double.NaN;
                if (textBoxCutoffFrequency2.Text.Trim() != "")
                    cutoffFreq2 = double.Parse(textBoxCutoffFrequency2.Text);

                int filterLength = int.Parse(textBoxFilterLength.Text);
                //only used for the Gauss window
                double gaussSigma = double.Parse(textBoxGaussSigma.Text);

                var windowStr = comboBoxWindow.Text;
                var window = GetMathNETWindowFromString(windowStr, gaussSigma);
                if (window == null) throw new Exception("Unable to determine window type");

                double[] coeffs = FilterCalc.CalcBandpassFilterMathDotNet(sampleRate, cutoffFreq1, cutoffFreq2, filterLength, window);

                string name = string.Format("Math.NET BP, SR: {0:0.}, Fc1: {1:0.0}, Fc2: {2:0.0}, " + windowStr, sampleRate, cutoffFreq1, cutoffFreq2);
                UpdateFilterResults(sampleRate, coeffs, name, cutoffFreq1, cutoffFreq2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonBPNWaves_Click(object sender, EventArgs e)
        {
            try
            {
                double sampleRate = double.Parse(textBoxSampleRate.Text);
                double cutoffFreq1 = double.Parse(textBoxCutoffFrequency1.Text);
                double cutoffFreq2 = double.NaN;
                if (textBoxCutoffFrequency2.Text.Trim() != "")
                    cutoffFreq2 = double.Parse(textBoxCutoffFrequency2.Text);

                int filterLength = int.Parse(textBoxFilterLength.Text);

                var windowStr = comboBoxWindow.Text;
                var window = GetNWavesWindowFromString(windowStr);

                double[] coeffs = FilterCalc.CalcBandpassFilterNWaves(sampleRate, cutoffFreq1, cutoffFreq2, filterLength, window);

                string name = string.Format("NWaves BP, SR: {0:0.}, Fc1: {1:0.0}, Fc2: {2:0.0}, " + windowStr, sampleRate, cutoffFreq1, cutoffFreq2);
                UpdateFilterResults(sampleRate, coeffs, name, cutoffFreq1, cutoffFreq2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
