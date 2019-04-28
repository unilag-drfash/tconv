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
        public static List<Matrix<T>> convolutionoperator(List<Matrix<T>> mainmatrix, Matrix<T> kernel, int stride = 1)
        {
        

            //var Mk = Matrix<T>.Build;
            //var mk = Mk.DenseOfArray(kernel);

            //dimensions of the mainmatrix
            int mdepth = mainmatrix.Count;
            int mcol = mainmatrix.ElementAt(0).ColumnCount;
            int mrow = mainmatrix.ElementAt(0).RowCount;


            //dimensions of the kernel matrix
            int krow = kernel.RowCount;
            int kcol = kernel.ColumnCount;

             

            int frow = ((mrow - krow) / stride) + 1;
            int fcol = ((mcol - kcol) / stride) + 1;

            
            //create the double array
            T[,] doublematrix = new T[frow, fcol];
            //storage for the new matrix
            List<Matrix<T>> newmatrix = new List<Matrix<T>>();
            


            for (int i = 0; i < mdepth; i++)
            {
                for(int j = 0; j < frow; j+=stride)
                {
                    for(int k = 0; k < fcol; k+=stride)
                    {
                        var b = mainmatrix.ElementAt(i).SubMatrix(j, krow, k, kcol);
                        var c = pointWiseMultiply(b, kernel);
                        var d = matrixSum(c);
                        doublematrix[j, k] = d;
                    }
                }
                newmatrix.Add(Matrix<T>.Build.DenseOfArray(doublematrix));
            }


            // var result = DenseMatrix.OfArray(kernel);
            return newmatrix;
        }

        public static List<Matrix<T>> poolingoperator(List<Matrix<T>> mainmatrix, int step = 1, int stride = 1)
        {


            //var Mk = Matrix<T>.Build;
            //var mk = Mk.DenseOfArray(kernel);

            //dimensions of the mainmatrix
            int mdepth = mainmatrix.Count;
            int mcol = mainmatrix.ElementAt(0).ColumnCount;
            int mrow = mainmatrix.ElementAt(0).RowCount;


            //dimensions of the kernel matrix
            int krow = step;
            int kcol = step;



            int frow = ((mrow - krow) / stride) + 1;
            int fcol = ((mcol - kcol) / stride) + 1;


            //create the double array
            T[,] doublematrix = new T[frow, fcol];
            //storage for the new matrix
            List<Matrix<T>> newmatrix = new List<Matrix<T>>();



            for (int i = 0; i < mdepth; i++)
            {
                for (int j = 0; j < frow; j += stride)
                {
                    for (int k = 0; k < fcol; k += stride)
                    {
                        var b = mainmatrix.ElementAt(i).SubMatrix(j, krow, k, kcol);
                        var c = b.Enumerate().Max();
                       
                        doublematrix[j, k] = c;
                    }
                }
                newmatrix.Add(Matrix<T>.Build.DenseOfArray(doublematrix));
            }


            // var result = DenseMatrix.OfArray(kernel);
            return newmatrix;
        }

        //change to private after unit testing
        public static Matrix<T> pointWiseMultiply(Matrix<T> slicedmatrix, Matrix<T> kernel)
        {
            try
            {
                
                return slicedmatrix.PointwiseMultiply(kernel);

            }
            catch (ArrayTypeMismatchException )
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
            }catch(ArrayTypeMismatchException )
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

        public static Matrix<T> sliceslice(Matrix<T> slicedmatrix)
        {
            try
            {
                return slicedmatrix.SubMatrix(0, 2, 0, 2);
            }
            catch (ArrayTypeMismatchException )
            {
                var Mk = Matrix<T>.Build;
                var mk = Mk.DenseOfArray(new T[2, 2]);
                return mk;
            }

        }
    }
}
