using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra;
using ConvolutionLayer.Operations;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MatrixPointWiseMulitply()
        {
            double[,] x = new double[2, 2] { { 1, 2 }, { 3, 4 } };
            double[,] y = new double[2, 2] { { 2, 3 }, { 4, 5 } };

            var Mx = Matrix<double>.Build;
            var mx = Mx.DenseOfArray(x);

            var My = Matrix<double>.Build;
            var my = My.DenseOfArray(y);

            double[,] supposedanswer = new double[2, 2] { { 2, 6 }, { 12, 20 } };
            var Msa = Matrix<double>.Build;
            var msa = Msa.DenseOfArray(supposedanswer);

            var result = Operators<double>.pointWiseMultiply(mx, my);
            Assert.AreEqual(result,msa);



        }

        [TestMethod]
        public void MatrixSum()
        {
            double[,] x = new double[2, 2] { { 1, 2 }, { 3, 4 } };
           

            var Mx = Matrix<double>.Build;
            var mx = Mx.DenseOfArray(x);

            var supposedanswer = 10;

            var result = Operators<double>.matrixSum(mx);
            Assert.AreEqual(result, supposedanswer);



        }

        [TestMethod]
        public void sliceslice()
        {
            double[,] x = new double[4, 4] { { 1, 2 ,9,10}, { 3, 4,11,12 } ,{ 5,6,13,14} ,{ 7,8,15,16} };
           // double[,] y = new double[2, 2] { { 2, 3 }, { 4, 5 } };

            var Mx = Matrix<double>.Build;
            var mx = Mx.DenseOfArray(x);

            //var My = Matrix<double>.Build;
            //var my = My.DenseOfArray(y);

            double[,] supposedanswer = new double[2, 2] { { 1, 2 }, { 3, 4 } };
            var Msa = Matrix<double>.Build;
            var msa = Msa.DenseOfArray(supposedanswer);

            var result = Operators<double>.sliceslice(mx);
            Assert.AreEqual(result, msa);



        }
    }
}
