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

        public static List<Matrix<double>> sharpenOperation(List<Matrix<double>> immatrix)
        {
            //kernel = np.matrix('0 -1 0 ; -1 5 -1 ; 0 -1 0');;; (Matrix<T>.Build.DenseOfArray(doublematrix
            Matrix<double> kernel = Matrix<double>.Build.DenseOfArray(new double[,] { { 0,-1,0} ,{-1,5,-1 },{0,-1,0 } });

            return Operations.Operators<double>.convolutionoperator(immatrix, kernel);
        }

        public static List<Matrix<double>> identityOperation(List<Matrix<double>> immatrix)
        {
            //kernel = np.matrix('0 0 0; 0 1 0 ; 0 0 0');
            Matrix<double> kernel = Matrix<double>.Build.DenseOfArray(new double[,] { { 0,0,0} , {0,1,0 },{0,0,0 } });
            return Operations.Operators<double>.convolutionoperator(immatrix, kernel);
        }

        public static List<Matrix<double>> blur1Operation(List<Matrix<double>> immatrix)
        {
            //kernel = np.matrix('1 0 -1; 0 0 0; -1 0 1')
            Matrix<double> kernel = Matrix<double>.Build.DenseOfArray(new double[,] { { 1, 0, -1 }, { 0, 0, 0 }, { -1, 0, 1 } });
            return Operations.Operators<double>.convolutionoperator(immatrix, kernel);

        }

        public static List<Matrix<double>> blur2Operation(List<Matrix<double>> immatrix)
        {
            // kernel = np.matrix('0 1 0; 1 -4 1; 0 1 0')
            Matrix<double> kernel = Matrix<double>.Build.DenseOfArray(new double[,] { { 0,1,0 }, { 1, -4, 1 }, { 0, 1, 0 } });
            return Operations.Operators<double>.convolutionoperator(immatrix, kernel);

        }

        public static List<Matrix<double>> blur3Operation(List<Matrix<double>> immatrix)
        {
            // kernel = np.matrix('-1 -1 -1; -1 8  -1; -1 -1 -1')
            Matrix<double> kernel = Matrix<double>.Build.DenseOfArray(new double[,] { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } });
            return Operations.Operators<double>.convolutionoperator(immatrix, kernel);

        }

        public static List<Matrix<double>> boxBlurOperation(List<Matrix<double>> immatrix)
        {
            // kernel = (1/9) * np.matrix('1 1 1 ; 1 1 1 ; 1 1 1')
            Matrix<double> kernel = Matrix<double>.Build.DenseOfArray(new double[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } });
            kernel.Multiply(1 / 9);
            return Operations.Operators<double>.convolutionoperator(immatrix, kernel);

        }
    }
}
