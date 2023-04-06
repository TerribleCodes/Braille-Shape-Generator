using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Braille_Shape_Generator_Service
{
    /// <summary>
    /// Summary description for Shape_Generator_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Shape_Generator_Service : System.Web.Services.WebService
    {

        // Edited By Madawa De Silva 28.03.2023

        [WebMethod]
        public double Circle(double radius)
        {
            return (Math.Round(Math.PI * radius * radius));
        }

        [WebMethod]
        public double Triangle(double height, double width)
        {
            return Math.Round(0.5 *height * width);
        }

        [WebMethod]
        public double Rectangle(double width, double height)
        {
            return width * height;
        }

        [WebMethod]
        public double Square(double length)
        {
            return length * length;
        }

        // Do the Number Generation
        [WebMethod]
        public int GetBrailleDots(string number)
        {
            int dots = 0;
            switch (number)
            {
                case "0":
                    dots = 3;
                    break;
                case "1":
                    dots = 1;
                    break;
                case "2":
                    dots = 2;
                    break;
                case "3":
                    dots = 2;
                    break;
                case "4":
                    dots = 3;
                    break;
                case "5":
                    dots = 2;
                    break;
                case "6":
                    dots = 3;
                    break;
                case "7":
                    dots = 4;
                    break;
                case "8":
                    dots = 3;
                    break;
                case "9":
                    dots = 2;
                    break;
                default:
                    dots = 0;
                    break;
            }
            return dots;
        }



        // Do the Letter Generation


    }
}
