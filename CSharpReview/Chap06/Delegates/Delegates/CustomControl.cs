using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Delegates
{
	public class CustomControl : UserControl
	{
		public enum FuncTypeEnum
		{
			Sin,
			Cos,
			Tan,
			Polynomial
		}

		FuncTypeEnum m_funcType = FuncTypeEnum.Sin;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public FuncTypeEnum FuncType
		{
			// get { return m_funcType; }
			set
			{
				if (m_funcType != value)
				{
					m_funcType = value;
					switch (m_funcType)
					{
						case FuncTypeEnum.Sin:
							m_funcGraph = m_funcSin;
							break;
						case FuncTypeEnum.Cos:
							m_funcGraph = m_funcCos;
							break;
						case FuncTypeEnum.Tan:
							m_funcGraph = m_funcTan;
							break;
						case FuncTypeEnum.Polynomial:
							m_funcGraph = m_funcPoly;
							break;
					}
					this.Invalidate();

					m_funcType = value;
				}
			}
		}

		public CustomControl()
		{
			this.ResizeRedraw = true;
			this.m_funcType = FuncTypeEnum.Sin;
			this.m_funcGraph = m_funcSin;
			this.Paint += new PaintEventHandler(OnPaint);
		}

		private void MapRect(Graphics g, Rectangle rctClient)
		{
			g.TranslateTransform(rctClient.Width / 2, rctClient.Height / 2);
			g.ScaleTransform(rctClient.Width / 4, -rctClient.Height / 4);
		}

		private void DrawAxis(Graphics g, Rectangle rctClient)
		{
			float flWidth = 1.0f / 72.0f;
			Pen pen = new Pen(Color.Black, flWidth);

			// Draw X and Y axis
			g.DrawLine(pen, -2, 0, 2, 0);
			g.DrawLine(pen, 0, -2, 0, 2);

			// Draw major grid lines
			for (int i = -20; i <= 20; i++)
			{
				if (i != 0)
				{
					g.DrawLine(pen, i / 10.0f, -0.05f, i / 10.0f, 0.05f);
					g.DrawLine(pen, -0.05f, -i / 10.0f, 0.05f, -i / 10.0f);
				}
			}

			pen.Dispose();
		}

		private void DrawGraph(Graphics g, Rectangle rctClient, Func<float, float> funcGraph)
		{
			if (funcGraph != null)
			{
				MapRect(g, rctClient);
				DrawAxis(g, rctClient);

				float flWidth = 1.0f / 72.0f;
				Pen pen = new Pen(Color.DarkRed, flWidth);
				for (float flXVal = -2; flXVal < 2; flXVal += 0.01f)
				{
					float x1 = flXVal * 180.0f * (float)(Math.PI / 180.0);
					float y1 = funcGraph(x1);

					float x2 = (flXVal + 0.1f) * 180.0f * (float)(Math.PI / 180.0);
					float y2 = funcGraph(x2);

					g.DrawLine(pen, flXVal, y1, flXVal + 0.01f, y2);
				}

				pen.Dispose();
			}
		}

		private void OnPaint(object? sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			Rectangle rctClient = this.ClientRectangle;
			DrawGraph(g, rctClient, m_funcGraph);
		}

		private Func<float, float> m_funcSin = (float x) => (float)Math.Sin(x);
		private Func<float, float> m_funcCos = (float x) => (float)Math.Cos(x);
		private Func<float, float> m_funcTan = (float x) => (float)Math.Tan(x);
		private Func<float, float> m_funcPoly = (float x) =>
			{
				const float A = -0.003f;
				const float B = -.0024f;
				const float C = 0.02f;
				const float D = 0.09f;
				const float E = -0.5f;
				const float F = 0.3f;
				const float G = 3.0f;

				return ((((((((A * x) + B) * x + C) * x + D) * x + E) * x + F) * x + G))/100.0f;
			};

		private Func<float, float> m_funcGraph;
	}
}
