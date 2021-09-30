using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class Graphs : Form
    {
        Pen pen = new Pen(Color.Red, 2.0F);

        List<PointF> sinePoints = new List<PointF> { };
        List<PointF> cosinePoints = new List<PointF> { };

        public Graphs()
        {
            InitializeComponent();
        }

        private double ConvertToRadians(int angle)
        {
            return (Math.PI * angle) / 180;
        }

        /// <summary>
        /// GetSin method that gets angle as an argument 
        /// </summary>
        /// <param name="angle">angle</param>
        /// <returns></returns>
        private double GetSin(int angle)
        {
            double radians = ConvertToRadians(angle);
            return Math.Sin(radians);
        }

        /// <summary>
        /// GetCos method that gets angle as an argument
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        private double GetCos(int angle)
        {
            double radians = ConvertToRadians(angle);
            return Math.Cos(radians);
        }

        private void CalculatePoints(int range)
        {
            for (int i = 0; i < range; i++)
            {
                float sineY = (float)GetSin(i) * (-1);
                float cosineY = (float)GetCos(i) * (-1);


                float sineScale = sineBox.Height / 2;
                float cosineScale = cosineBox.Height / 2;

                sinePoints.Add(new PointF(i, sineY * sineScale + sineScale));
                cosinePoints.Add(new PointF(i, cosineY * cosineScale + cosineScale));
            }
        }
        private void InvalidateBoxes()
        {
            sineBox.Invalidate();
            cosineBox.Invalidate();
        }
        private void sineBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (sinePoints.Count()>0)
            {
                e.Graphics.DrawCurve(pen, sinePoints.ToArray());
            }
        }

        private void cosineBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (cosinePoints.Count() > 0)
            {
                e.Graphics.DrawCurve(pen, cosinePoints.ToArray());
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            CalculatePoints(1000);
            InvalidateBoxes();
        }
    }
}
