using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Structure;
using MathNet.Numerics.LinearAlgebra;

namespace ConvolutionLayer
{
    class Image
    {
        private static Image singleton = null;
      
        private string path;
    
        private Image<Bgr, Byte> img;
        private List<MathNet.Numerics.LinearAlgebra.Matrix<double>> matrix;

        private Image(string path)
        {
            this.path = path;
            this.img = new Image<Bgr, Byte>(this.path);
            this.matrix = new List<MathNet.Numerics.LinearAlgebra.Matrix<double>>();
        }

      

        public static Image getInstance()
        {
            if (singleton == null)
                throw new Exception("You have to call the init(string arg1) method");

            return singleton;
        }

        public static Image init(string path)
        {
            if (singleton != null)
                throw new Exception("Object already initialized call the getInstance() method");

            singleton = new Image(path);
            singleton.initMatrix();
            
            return singleton;
        }
       
        public Image<Bgr, Byte> GetImage()
        {
            return this.img;
        }

        private List<MathNet.Numerics.LinearAlgebra.Matrix<double>> initMatrix()
        {
            //List<MathNet.Numerics.LinearAlgebra.Matrix<double>> matrix = new List<MathNet.Numerics.LinearAlgebra.Matrix<double>>();
            int rowcount = this.img.Rows;
            int colcount = this.img.Cols;
            int channelcount = this.img.NumberOfChannels;

            //byte[,] temparray = new byte[rowcount, colcount] ;
            double[,] dtemparray = new double[rowcount, colcount];

            for(int i = 0; i < channelcount; i++)
            {
                for(int j = 0; j < rowcount; j++)
                {
                    for(int k = 0; k < colcount; k++)
                    {
                        dtemparray[j, k] = this.img.Data[j, k, i];
                    }
                }
                //convert the byte array to double
                // dtemparray = BitConverter.ToDouble(temparray,0);

                //converting the double to Matrix format
                var Mx = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build;
                var mx = Mx.DenseOfArray(dtemparray);
                this.matrix.Add(mx);
            }

            return this.matrix;


        }


        public List<MathNet.Numerics.LinearAlgebra.Matrix<double>> getImageMatrix()
        {
            return this.matrix;
        }

        public void setImageMatrix(List<MathNet.Numerics.LinearAlgebra.Matrix<double>> matrix)
        {
            this.matrix = matrix;
        }

        public 
    }

    
}
