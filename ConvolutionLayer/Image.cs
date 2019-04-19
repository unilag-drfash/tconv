using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Structure;

namespace ConvolutionLayer
{
    class Image
    {
        private static Image singleton = null;
      
        private string path;
    
        private Image<Bgr, Byte> img;

        private Image(string path)
        {
            this.path = path;
            this.img = new Image<Bgr, Byte>(this.path);
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
            return singleton;
        }
       
        public Image<Bgr, Byte> GetImage()
        {
            return this.img;
        }
    }

    
}
