using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace ConvolutionLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Form1 form = new Form1();
            Image im = Image.init("C:\\Users\\TOLIZU\\Pictures\\g1.jpeg");
            var a = im.GetImage().Data;
            //Console.WriteLine(a[0,0,1]);

          //  Console.WriteLine(im.GetImage());
            Console.ReadLine();
            form.ShowDialog();
            
        }

       
    }


}
