using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filter_design_gui
{
    class FilterCalc
    {
        /**
         * Calculate a lowpass FIR filter using Math.NET Filtering (https://www.mathdotnet.com/)
         */
        public static double[] CalcLowpassFilterMathDotNet(double sampleRate, double cutoffFrequency, int filterLength, MathNet.Filtering.Windowing.Window window)
        {
            var mathNetCoeffs = MathNet.Filtering.FIR.FirCoefficients.LowPass(sampleRate, cutoffFrequency, 1.0, filterLength / 2);
            window.Width = mathNetCoeffs.Length;
            window.Precompute();
            var windowArray = window.CopyToArray();
            for (int i = 0; i < mathNetCoeffs.Count(); i++)
            {
                mathNetCoeffs[i] *= windowArray[i];
            }

            return mathNetCoeffs;
        }

        /**
         * Calculate a bandpass FIR filter using Math.NET Filtering (https://www.mathdotnet.com/)
         */
        public static double[] CalcBandpassFilterMathDotNet(double sampleRate, double cutoffFrequencyLow, double cutoffFrequencyHigh, int filterLength, MathNet.Filtering.Windowing.Window window)
        {
            var mathNetCoeffs = MathNet.Filtering.FIR.FirCoefficients.BandPass(sampleRate, cutoffFrequencyLow, cutoffFrequencyHigh, filterLength / 2);
            window.Width = mathNetCoeffs.Length;
            window.Precompute();
            var windowArray = window.CopyToArray();
            for (int i = 0; i < mathNetCoeffs.Count(); i++)
            {
                mathNetCoeffs[i] *= windowArray[i];
            }

            return mathNetCoeffs;
        }
    }
}
