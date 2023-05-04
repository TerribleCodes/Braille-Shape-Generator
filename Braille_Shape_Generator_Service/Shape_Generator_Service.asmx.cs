using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        [WebMethod (EnableSession =true)]
        public double Circle(double radius)
        {
            double CircleDots = (Math.Round(Math.PI * 2 * radius));

            //Generate Recent Activities for Circles (DDS)
            List<String> circles;

            if (Session["CIRCLE"] == null)
            {
                circles = new List<string>();
            }
            else
            {
                circles = (List<string>)Session["CIRCLE"];
            }
            string strRecentCircle ="Circle :"+ CircleDots.ToString();
            circles.Add(strRecentCircle);
            Session["CIRCLE"] = circles;

            return CircleDots;
        }
        [WebMethod(EnableSession = true)]
        public List<string> GetCircle()
        {
            if (Session["CIRCLE"] == null)
            {
                List<string> circles = new List<string>();
                circles.Add("You have not performed anything");
                return circles;
            }
            else
            {
                return (List<string>)Session["CIRCLE"];
            }
        }

        [WebMethod (EnableSession =true)]
        public double Triangle(double height, double width)
        {
           double TriangleDots= Math.Round(0.5 * height * width);
            //Generate Recent Activities for triangles
            List<String> triangles;

            if (Session["TRIANGLE"] == null)
            {
                triangles = new List<string>();
            }
            else
            {
                triangles = (List<string>)Session["TRIANGLE"];
            }
            string strRecentTriangle ="Triangle :"+TriangleDots.ToString();
            triangles.Add(strRecentTriangle);
            Session["TRIANGLE"] = triangles;

            return TriangleDots;
        }
        [WebMethod(EnableSession = true)]
        public List<string> GetTriangle()
        {
            if (Session["TRIANGLE"] == null)
            {
                List<string> triangles = new List<string>();
                triangles.Add("You have not performed anything");
                return triangles;
            }
            else
            {
                return (List<string>)Session["TRIANGLE"];
            }
        }
        [WebMethod (EnableSession =true)]
        public double Rectangle(double width, double height)
        {
            double RecDots= (2*width)+(2*height);
            //Generate Recent Activities for 
            List<String> rectangles;

            if (Session["RECTANGLE"] == null)
            {
                rectangles = new List<string>();
            }
            else
            {
                rectangles = (List<string>)Session["RECTANGLE"];
            }
            string strRecentRectangle ="Width :"+ height.ToString() + " "+"Height :"+ width.ToString() + " "+"***# of Dots for Rectangle :"+ RecDots.ToString();
            rectangles.Add(strRecentRectangle);
            Session["RECTANGLE"] = rectangles;
            return RecDots;
        }
        [WebMethod(EnableSession = true)]
        public List<string> GetRectangle()
        {
            if (Session["RECTANGlE"] == null)
            {
                List<string> rectangles = new List<string>();
                rectangles.Add("You have not performed anything");
                return rectangles;
            }
            else
            {
                return (List<string>)Session["RECTANGLE"];
            }
        }

        [WebMethod(EnableSession = true)]
        public double Square(double length)
        {
            double SqDots= length*4;
            return SqDots;
        }

        // Do the Number Generation
        [WebMethod(EnableSession = true)]
        public int GetBrailleDots(string number)
        {
            //Generate Recent Activities for Numbers
            List<String> numbers;

            if (Session["NUMBERS"] == null)
            {
                numbers = new List<string>();
            }
            else
            {
                numbers = (List<string>)Session["NUMBERS"];
            }
            string strRecentNumbers = number;
            numbers.Add(strRecentNumbers);
            Session["NUMBERS"] = numbers;


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

        [WebMethod(EnableSession = true)]
        public List<string> GetNumbers()
        {
            if (Session["NUMBERS"] == null)
            {
                List<string> numbers = new List<string>();
                numbers.Add("You have not performed anything");
                return numbers;
            }
            else
            {
                return (List<string>)Session["NUMBERS"];
            }
        }

        //Letter Generation
        [WebMethod (EnableSession=true)]
        public int GetBrailleDotsLetters(string letter)
        {

            //Generate Recent Activities for Letters
            List<String> letters;

            if (Session["LETTERS"] == null)
            {
                letters = new List<string>();
            }
            else
            {
                letters = (List<string>)Session["LETTERS"];
            }
            string strRecentLetters = letter;
            letters.Add(strRecentLetters);
            Session["NUMBERS"] = letters;

            int dots = 0;
            switch (letter)
            {
                case "A":
                    dots = 1;
                    break;

                case "B":
                    dots = 2;
                    break;

                case "C":
                    dots = 2;
                    break;

                case "D":
                    dots = 3;
                    break;

                case "E":
                    dots = 2;
                    break;

                case "F":
                    dots = 3;
                    break;

                case "G":
                    dots = 4;
                    break;

                case "H":
                    dots = 3;
                    break;

                case "I":
                    dots = 2;
                    break;

                case "J":
                    dots = 3;
                    break;

                case "K":
                    dots = 2;
                    break;

                case "L":
                    dots = 3;
                    break;

                case "M":
                    dots = 3;
                    break;

                case "N":
                    dots = 4;
                    break;

                case "O":
                    dots = 3;
                    break;

                case "P":
                    dots = 4;
                    break;

                case "Q":
                    dots = 5;
                    break;

                case "R":
                    dots = 4;
                    break;

                case "S":
                    dots = 3;
                    break;

                case "T":
                    dots = 4;
                    break;

                case "U":
                    dots = 3;
                    break;

                case "V":
                    dots = 4;
                    break;

                case "W":
                    dots = 4;
                    break;

                case "X":
                    dots = 4;
                    break;

                case "Y":
                    dots = 5;
                    break;

                case "Z":
                    dots = 4;
                    break;

                default:
                    dots = 0;
                    break;
            }
            return dots;
        }
        [WebMethod(EnableSession = true)]
        public List<string> GetLetters()
        {
            if (Session["LETTERS"] == null)
            {
                List<string> letters = new List<string>();
                letters.Add("You have not performed anything");
                return letters;
            }
            else
            {
                return (List<string>)Session["LETTERS"];
            }
        }
    }
}