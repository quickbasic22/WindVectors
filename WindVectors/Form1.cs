using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindVectors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumUpDownWindDirection.Maximum = 360;
            NumUpDownWindMagnitude.Maximum = 10000;
            TxtAirplaneMagnitude.Text = 3.ToString();
            TxtAirplaneDirection.Text = 1.73205.ToString();
            NumUpDownWindMagnitude.Value = 100;
            NumUpDownWindDirection.Value = 0;

        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            double planeMag = double.Parse(TxtAirplaneMagnitude.Text);
            double planeDir = double.Parse(TxtAirplaneDirection.Text);
           // double WindMag = double.Parse(NumUpDownWindMagnitude.Value.ToString());
           // double WindDir = double.Parse(NumUpDownWindDirection.Value.ToString());
            var (x, y) = RectangularToPolar(planeMag, planeDir);

            double degreeResult = Convert_RadiansToDegrees(y);
           
            y = AdjustAnglesToQuadrant(x, degreeResult);


            TxtPlaneSpeedResult.Text = x.ToString();
            TxtPlaneDirectionResult.Text = Math.Round(y, 0).ToString();

            //var (r, Beta) = PolarToRectangular(WindMag, WindDir);
            //System.Diagnostics.Debug.WriteLine($"r = {0} Beta = {1}", r, Beta);


            //double Mag = x + r;
            //double Dir = y + Beta;
            //var (resr, resBeta) = RectangularToPolar(Mag, Dir);
            //TxtPlaneSpeedResult.Text = resr.ToString();
            //TxtPlaneDirectionResult.Text = resBeta.ToString();

            //Debug.WriteLine($"Answer is r ={0} Beta ={1}", RectangularToPolar(-450, 0).r, RectangularToPolar(-450, 0).Beta);


        }

        private static (double x, double y) PolarToRectangular(double r, double Beta)
        {
            Debug.WriteLine($"r = {r} Beta = {Beta} in PolarToRectangular Method", r, Beta);
            // Beta = Math.PI / 180 * Beta;
            double x = Math.Round(r * Math.Cos(Beta), 0);
            double y = Math.Round(r * Math.Sin(Beta), 0);

            return (x: x, y: y);
        }

        private static (double r, double Beta) RectangularToPolar(double x, double y)
        {
            Debug.WriteLine($"x = {x} Beta = {y} in RectangularToPolar Method", x, y);
            double r = Math.Round(Math.Sqrt(Math.Pow(Math.Abs(x), 2) + Math.Pow(Math.Abs(y), 2)),2);
            double Beta = Math.Atan(y / x);
            // Beta = 180 / Math.PI * Beta;
            if (x <= -1 && y == 0)
                    Beta = 3.14159;

            Debug.WriteLine($"r = {r} Beta = {Beta}", r, Beta);

            return (r: r, Beta: Beta);
        }

        private static double Convert_RadiansToDegrees(double radians)
        {
            double result = 180 / Math.PI * radians;
            return result;
        }

        private static double Convert_DegreesToRadians(double degrees)
        {
            double result = Math.PI / 180 * degrees;
            return result;
        }

        private static double AdjustAnglesToQuadrant(double x, double y)
        {
            if (!Double.IsNegative(x) && !Double.IsNegative(y))
            {
                return y + 180;
            }
            else if (Double.IsNegative(x) && !Double.IsNegative(y))
            {
                return y + 180;
            }
            else if (!Double.IsNegative(x) && Double.IsNegative(y))
            {
                return y + 360;
            }
            else if (!Double.IsNegative(x) && Double.IsNegative(y))
            {
                return y;
            }
            return x;
        }

    }
}
