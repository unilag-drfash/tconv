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
           // Image im = Image.init("C:\\Users\\TOLIZU\\Pictures\\g3.jpeg");
            
           // var a = im.GetImage();
           //   var b = Array.CreateInstance(Double, a.Rows, a.Cols, a.NumberOfChannels); b = a.ManagedArray; ;
          //  Console.WriteLine(a.Rows + " " + a.Cols + " " + a.NumberOfChannels);
           // Console.WriteLine();
            //var b = a.Data;
            //Console.WriteLine(b[0,0,0]);

          //  Console.WriteLine(im.GetImage());
          //  Console.ReadLine();
            form.ShowDialog();
            
        }

       
    }


}
