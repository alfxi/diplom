using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace quantumemu
{
    public class Qubit
    {
        private Complex alpha;  // Coefficient for |0>
        private Complex beta;   // Coefficient for |1>

        private static Random random = new Random();

        public Qubit()
        {
            // Initialize the qubit in the |0> state
            alpha = Complex.One;
            beta = Complex.Zero;
        }

        public void ApplyXGate()
        {
            // Apply the X gate (bit-flip) to the qubit
            Complex temp = alpha;
            alpha = beta;
            beta = temp;
        }

        public void ApplyYGate()
        {
            // Apply the Y gate to the qubit
            Complex temp = alpha;
            alpha = Complex.ImaginaryOne * beta;
            beta = -Complex.ImaginaryOne * temp;
        }

        public void ApplyZGate()
        {
            // Apply the Z gate (phase-flip) to the qubit
            beta = -beta;
        }

        public void ApplyHGate()
        {
            // Apply the H (Hadamard) gate to the qubit
            Complex sqrt2 = Math.Sqrt(2);
            Complex newAlpha = (alpha + beta) / sqrt2;
            Complex newBeta = (alpha - beta) / sqrt2;
            alpha = newAlpha;
            beta = newBeta;
        }
        public void ApplyTGate()
        {
            // Apply the T gate to the qubit
            Complex tPhase = new Complex(Math.Cos(Math.PI / 4), Math.Sin(Math.PI / 4));
            beta *= tPhase;
        }

        public void ApplySGate()
        {
            // Apply the S gate to the qubit
            Complex sPhase = new Complex(0, 1);
            beta *= sPhase;
        }


        public int Measure()
        {
            // Perform a measurement on the qubit and return the outcome (0 or 1)
            double probZero = Complex.Abs(alpha) * Complex.Abs(alpha);
            double randomValue = random.NextDouble();

            if (randomValue < probZero)
            {
                // Qubit collapsed to |0>
                alpha = Complex.One;
                beta = Complex.Zero;
                return 0;
            }
            
            else
            {
                // Qubit collapsed to |1>
                alpha = Complex.Zero;
                beta = Complex.One;
                return 1;
            }
        }

        public void Normalize()
        {
            // Normalize the qubit state
            double norm = Math.Sqrt(alpha.Magnitude * alpha.Magnitude + beta.Magnitude * beta.Magnitude);
            alpha /= norm;
            beta /= norm;
        }

        public Complex GetAlpha()
        {
            // Get the coefficient for |0>
            return alpha;
        }

        public Complex GetBeta()
        {
            // Get the coefficient for |1>
            return beta;
        }

        public double[] GetAmplitudes()
        {
            // Calculate the probabilities for |0> and |1>
            double probZero = Complex.Multiply(alpha, Complex.Conjugate(alpha)).Real;
            double probOne = Complex.Multiply(beta, Complex.Conjugate(beta)).Real;

            // Create an array of doubles to hold the probabilities
            double[] amplitudes = new double[2];
            amplitudes[0] = probZero;
            amplitudes[1] = probOne;

            // Return the probabilities as an array
            return amplitudes;
        }
    }
}