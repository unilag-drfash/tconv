using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvolutionLayer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

      
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Image im = Image.init("C:\\Users\\TOLIZU\\Pictures\\g1.jpeg");
                Image im = Image.getInstance();
                this.pictureBox1.Image = im.GetImage().Bitmap;
                this.pictureBox1.Show();

            }
            catch(Exception en)
            {
                MessageBox.Show("An exception occured." + en);
                
            }
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
