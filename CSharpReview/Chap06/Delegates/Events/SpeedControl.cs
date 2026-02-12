using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
	public class SpeedControl : UserControl
	{
		public SpeedControl()
		{
			this.BackColor = System.Drawing.Color.Green;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Paint += new PaintEventHandler(OnPaint);
		}

		public void AddSpeedChangedSubscriber(EventTrackBar trkbarGasPedal)
		{
			trkbarGasPedal.AddSpeedChangedSubscriber(OnSpeedChanged);
		}

		protected void DrawSpeedometer(Graphics g, Rectangle clientRect)
		{
			g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Blue), 0, 0, this.Width, this.Height);

			DrawSpeedometerFace(g, clientRect);
		}

		private void DrawSpeedometerFace(Graphics g, Rectangle clientRect)
		{
			g.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.Black, 2), 10, 10, this.Width - 20, this.Height - 20);
			g.FillEllipse(new System.Drawing.SolidBrush(System.Drawing.Color.White), 12, 12, this.Width - 18, this.Height - 18);

			Point center = new Point(this.Width / 2, this.Height / 2);
			int radius = Math.Min(this.Width, this.Height) / 2 - 20;

			// Draw the speedometer ticks
			Pen penBlack = new System.Drawing.Pen(System.Drawing.Color.Black, 1);
			int nMPH = 0;

			Font drawFont = new Font("Arial", 10);
			SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);

			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;

			for (int i = 220; i >= -40; i -= 10)
			{
				String drawString = String.Format("{0}", nMPH);
				nMPH += 5;

				int x1 = center.X + (int)(radius * Math.Cos(i * Math.PI / 180));
				int y1 = center.Y - (int)(radius * Math.Sin(i * Math.PI / 180));
				int x2 = center.X + (int)((radius - 10) * Math.Cos(i * Math.PI / 180));
				int y2 = center.Y - (int)((radius - 10) * Math.Sin(i * Math.PI / 180));
				g.DrawLine(penBlack, x1, y1, x2, y2);

				int x3 = center.X + (int)((radius - 30) * Math.Cos(i * Math.PI / 180));
				int y3 = center.Y - (int)((radius - 30) * Math.Sin(i * Math.PI / 180));
				g.DrawString(drawString, drawFont, drawBrush, new PointF(x3, y3), stringFormat);
			}

			drawBrush.Dispose();
			drawFont.Dispose();
			penBlack.Dispose();
		}

		protected void ShowSpeed(Graphics g, int speed)
		{
			ShowSpeed(g, speed, System.Drawing.Color.Red);
		}

		protected void EraseSpeed(Graphics g, int speed)
		{
			ShowSpeed(g, speed, System.Drawing.Color.White);
			DrawSpeedometerFace(g, this.ClientRectangle);
		}

		protected void ShowSpeed(Graphics g, int speed, Color color)
		{
			Point center = new Point(this.Width / 2, this.Height / 2);
			int radius = Math.Min(this.Width, this.Height) / 2 - 20;

			// Convert speed to angle in degrees
			speed = (int)(220 - (2 * speed));

			// Draw the speedometer needle
			int x = center.X + (int)(radius * Math.Cos(speed * Math.PI / 180));
			int y = center.Y - (int)(radius * Math.Sin(speed * Math.PI / 180));
			g.DrawLine(new System.Drawing.Pen(color, 2), center.X, center.Y, x, y);
		}

		protected void OnPaint(Object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = CreateGraphics();
			Rectangle clientRect = this.ClientRectangle;
			DrawSpeedometer(g, clientRect);

			ShowSpeed(g, m_nSpeed);

			g.Dispose();
		}

		protected void OnSpeedChanged(object sender, EventTrackBarEventArgs e)
		{
			Graphics g = CreateGraphics();
			Rectangle clientRect = this.ClientRectangle;
			EraseSpeed(g, m_nSpeed);
			m_nSpeed = e.Speed;
			ShowSpeed(g, m_nSpeed);
			g.Dispose();
		}

		private int m_nSpeed = 0;
	}
}
