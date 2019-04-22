using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionLayer.Operations
{
    public static class Operators<T> where T : struct, IEquatable<T>, IFormattable
    {
        public static double convolutionoperator(T[,] mainmatrix, T[,] kernel)
        {

            var Mk = Matrix<T>.Build;
            var mk = Mk.DenseOfArray(kernel);

            var Ms = Matrix<T>.Build;
            var ms = Ms.DenseOfArray(mainmatrix);

            // var result = DenseMatrix.OfArray(kernel);
            return 0.0;
        }

        //change to private after unit testing
        public static Matrix<T> pointWiseMultiply(Matrix<T> slicedmatrix, Matrix<T> kernel)
        {
            try
            {
                return slicedmatrix.PointwiseMultiply(kernel);
            }
            catch (ArrayTypeMismatchException e)
            {
                var Mk = Matrix<T>.Build;
                var mk = Mk.DenseOfArray(new T[2,2]);
                return mk;
            }
            
        }

        public static T matrixSum(Matrix<T> mainmatrix)
        {
            try
            {
                var r = mainmatrix.ColumnSums();
                return r.Sum();
            }catch(ArrayTypeMismatchException e)
            {

               
                return new T();
            }
        }


        public static void slide(Matrix<T> mainmatrix, Matrix<T> kernel)
        {
            int imagerow = mainmatrix.RowCount;
            int imagecol = mainmatrix.ColumnCount;
            //int depth = mainmatrix[]
        }
    }
}
