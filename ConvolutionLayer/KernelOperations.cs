using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
namespace ConvolutionLayer
{
    public static class KernelOperations
    {
        //create individual kernel operations

        private double convolutionoperation(byte[,] slicedmatrix, byte[,] kernel)
        {
            
            List < List<byte> > kernel1 = new List<List<byte>>(kernel);
            var result = DenseMatrix(kernel);
        }
    }
}
