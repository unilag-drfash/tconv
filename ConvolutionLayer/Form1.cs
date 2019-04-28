﻿using System;
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
                Image.clearInstance();

                Image im = Image.init("C:\\Users\\TOLIZU\\Pictures\\g3.jpeg");
                this.pictureBox1.Image = im.GetImage().Bitmap;
                this.pictureBox1.Show();
                this.pictureBox2.Hide();

            }
            catch(Exception )
            {
              

            }
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PoolingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image im = Image.getInstance();
            var result = Operations.Operators<double>.poolingoperator(im.getImageMatrix(),3);
            im.setImageData(result);
            this.pictureBox2.Image = im.GetImage().Bitmap;
            this.pictureBox2.Show();
        }

        private void SharpenOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image im = Image.getInstance();
            Console.WriteLine("start");
            var result = KernelOperations.sharpenOperation(im.getImageMatrix());
            Console.WriteLine("stop");
            im.setImageData(result);
            Console.WriteLine("set");
            this.pictureBox2.Image = im.GetImage().Bitmap;
            Console.WriteLine("show");
            this.pictureBox2.Show();
        }

        private void IdentityOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image im = Image.getInstance();
            Console.WriteLine("start");
            var result = KernelOperations.identityOperation(im.getImageMatrix());
            Console.WriteLine("stop");
            im.setImageData(result);
            Console.WriteLine("set");
            this.pictureBox2.Image = im.GetImage().Bitmap;
            Console.WriteLine("show");
            this.pictureBox2.Show();
        }

        private void EdgeDetectionOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Type1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image im = Image.getInstance();
            Console.WriteLine("start");
            var result = KernelOperations.blur1Operation(im.getImageMatrix());
            Console.WriteLine("stop");
            im.setImageData(result);
            Console.WriteLine("set");
            this.pictureBox2.Image = im.GetImage().Bitmap;
            Console.WriteLine("show");
            this.pictureBox2.Show();

        }

        private void Type2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image im = Image.getInstance();
            Console.WriteLine("start");
            var result = KernelOperations.blur2Operation(im.getImageMatrix());
            Console.WriteLine("stop");
            im.setImageData(result);
            Console.WriteLine("set");
            this.pictureBox2.Image = im.GetImage().Bitmap;
            Console.WriteLine("show");
            this.pictureBox2.Show();
        }

        private void Type3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image im = Image.getInstance();
            Console.WriteLine("start");
            var result = KernelOperations.blur3Operation(im.getImageMatrix());
            Console.WriteLine("stop");
            im.setImageData(result);
            Console.WriteLine("set");
            this.pictureBox2.Image = im.GetImage().Bitmap;
            Console.WriteLine("show");
            this.pictureBox2.Show();
        }

        private void BoxBlurOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image im = Image.getInstance();
            Console.WriteLine("start");
            var result = KernelOperations.boxBlurOperation(im.getImageMatrix());
            Console.WriteLine("stop");
            im.setImageData(result);
            Console.WriteLine("set");
            this.pictureBox2.Image = im.GetImage().Bitmap;
            Console.WriteLine("show");
            this.pictureBox2.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
