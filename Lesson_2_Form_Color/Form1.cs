using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_dz2
{
	public partial class Form_Colors : Form
	{
		byte R = 128, G = 128, B = 128;

    
        public Form_Colors()
		{
			InitializeComponent();
			BackColor = Color.FromArgb(R, G, B);
		}

		private void change_color(object sender, EventArgs e)
		{
			if (sender == trackBar_R)
			{
				R = Convert.ToByte(trackBar_R.Value);
			}
			if (sender == trackBar_G)
			{
				G = Convert.ToByte(trackBar_G.Value);
			}
			if (sender == trackBar_B)
			{
				B = Convert.ToByte(trackBar_B.Value);
			}

			BackColor = Color.FromArgb(R, G, B);
			tb_RGB.Text = $"{trackBar_R.Value}, {trackBar_G.Value}, {trackBar_B.Value}";

			if (BackColor.R == 128 && BackColor.G == 128 && BackColor.B == 128)
			{
				lb_1_title.ForeColor = Color.Black;
				lb_R.ForeColor = Color.Black;
				lb_G.ForeColor = Color.Black;
				lb_B.ForeColor = Color.Black;
				lb_Color.ForeColor = Color.Black;
			}
			else 
			{
				lb_1_title.ForeColor = Color.FromArgb(Math.Abs(R-255),Math.Abs(G-255),Math.Abs(B-255));
				lb_R.ForeColor = Color.FromArgb(Math.Abs(R - 255), Math.Abs(G - 255), Math.Abs(B - 255));
				lb_G.ForeColor = Color.FromArgb(Math.Abs(R - 255), Math.Abs(G - 255), Math.Abs(B - 255));
				lb_B.ForeColor = Color.FromArgb(Math.Abs(R - 255), Math.Abs(G - 255), Math.Abs(B - 255));
				lb_Color.ForeColor = Color.FromArgb(Math.Abs(R - 255), Math.Abs(G - 255), Math.Abs(B - 255));
			}
		}
	}
}
