using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
   interface Phone
    {
         void GetPhoneDetail();
    }

    interface Camera
    {
         void GetCameraDetail();
    }

    public class Smartphone : Phone , Camera
    {
        public void GetPhoneDetail()
        {
            Console.WriteLine("Phone Detail is : Realme-7 ");
        }
        public void GetCameraDetail()
        {
            Console.WriteLine("Camera Detail is : 64 Mega pixels");
        }
    }

}
