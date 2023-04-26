using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_050423
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
			switch (e.Button) {
				case MouseButtons.Left: {
						int x = e.Location.X;
						int y = e.Location.Y;

						if (x < 10) {
							MessageBox.Show("Left edge");
						} else if (x > this.Width - 10) {
							MessageBox.Show("Right edge");
						} else if (y > this.Height - 10) {
							MessageBox.Show("Bottom edge");
						} else if (y < 10) {
							MessageBox.Show("Top edge");
						} else {
							MessageBox.Show("Middle");
						}
						break;
					}
				case MouseButtons.Right: {
						MessageBox.Show("Window dimensions: " + this.Width + " x " + this.Height);
						break;
					}
			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			this.Text = "Mouse X: " + e.X + ", Mouse Y: " + e.Y;
		}
	}
}
