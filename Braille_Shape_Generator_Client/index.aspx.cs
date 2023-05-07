using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Braille_Shape_Generator_Client
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            /*
                +++++++++ SHAPE GENERATOR +++++++++
                 Uses the "ShapeGeneratorService"
                
            Tasks: 
                - [x] Front-End Data Validation
                - [x] Communication with the service
                - [x] Calculating the number of dots
                - [x] Generating the patterns (Implementing the algorithms)
             */
            // COMPLETED 1st 3 tasks by Madawa De Silva on 04.02.2023@8:42PM


            Label10.Text = EnterHeight.Text + EnterRadius.Text + EnterWidth.Text + shape_drop_down.Text; ;
            ShapeGeneratorService.Shape_Generator_ServiceSoapClient client = new ShapeGeneratorService.Shape_Generator_ServiceSoapClient();

            // Square
            if (shape_drop_down.Text == "square")
            {
                double result = client.Square(Convert.ToDouble(EnterHeight.Text));
                Label10.Text = "Number of dots required for the Square: "+result.ToString();
                int Size = Convert.ToInt32(EnterHeight.Text);
                StringBuilder sb = new StringBuilder("");
                Console.WriteLine("Enter the size of the square: ");
                Size = Convert.ToInt32(Console.ReadLine());

                for (int row = 0; row < Size; row++)
                {
                    for (int column = 0; column < Size; column++)
                    {
                        sb.Append("*" + " ");
                    }
                    Label11.Text = sb.ToString();
                }
            }

            // Rectangle
            if (shape_drop_down.Text == "rectangle")
            {
                double result = client.Rectangle(Convert.ToDouble(EnterHeight.Text), Convert.ToDouble(EnterWidth.Text));
                Label10.Text = "Number of dots required for the Rectangle: " + result.ToString();
                int height = Convert.ToInt32(EnterHeight.Text);
                int width = Convert.ToInt32(EnterWidth.Text);
                StringBuilder sb = new StringBuilder("");
                for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= width; j++)
                    {
                        if ((i == 1 || i == height) || (j == 1 || j == width))
                            sb.Append("*");
                        else
                            sb.Append(" ");
                    }
                    sb.Append("\n");
                }
                Label11.Text = sb.ToString();
            }
            

            // Triangle
            if (shape_drop_down.Text == "triangle")
            {
                double result = client.Triangle(Convert.ToDouble(EnterHeight.Text), Convert.ToDouble(EnterWidth.Text));
                Label10.Text = "Number of dots required for the Triangle: "+result.ToString();
                StringBuilder sb = new StringBuilder("");
                int val = Convert.ToInt32(EnterHeight.Text);
                int i, j, k;
                for (i = 1; i <= val; i++)
                {
                    for (j = 1; j <= val - i; j++)
                    {
                        sb.Append(" ");
                    }
                    for (k = 1; k <= i; k++)
                    {
                        sb.Append("*");
                    }
                    sb.Append("\n");
                }
                Label11.Text = sb.ToString();
            }   
            
            
            // Circle
            if (shape_drop_down.Text == "circle")
            {
                double result = client.Circle(Convert.ToDouble(EnterRadius.Text));
                Label10.Text = "Number of dots required for the Circle: "+result.ToString();
                int radius = Convert.ToInt32(EnterRadius.Text);
                StringBuilder sb = new StringBuilder("");
                double console_ratio = Convert.ToDouble(4.0 / 2.0);
                double a = console_ratio * radius;
                double b = radius;
                for (int y = -radius; y <= radius; y++)
                {
                    for (double x = -a; x <= a; x++)
                    {
                        double d = (x / a) * (x / a) + (y / b) * (y / b);
                        if (d > 0.90 && d < 1.2)
                        {
                            sb.Append("*");
                        }
                        else
                        {
                            sb.Append(" ");
                        }
                    }
                    sb.Append(" \n");
                }
                Label11.Text = sb.ToString();

            }
            if (shape_drop_down.Text == "select")
            {
                Label10.Text = "Please select a shape or a Character";
            }
            Madawa.DataSource = client.GetCircle();
            Madawa.DataSource = client.GetTriangle();
            Madawa.DataSource = client.GetRectangle();
            Madawa.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            /*
               +++++++++ NUMBER GENERATOR +++++++++
                Uses the "ShapeGeneratorService"

           Tasks: 
               
               - [x] Communication with the service
               - [x] Calculating the number of dots
               - [x] Generating the braille numbers
            */
            // COMPLETED 1st 2 tasks by Himasha Gayathri on 04/06/2023

            ShapeGeneratorService.Shape_Generator_ServiceSoapClient client = new ShapeGeneratorService.Shape_Generator_ServiceSoapClient();
            {
                // Call the GetBrailleDots method in the web service and pass in the selected number from the drop-down list
                if (CharactersDropDownList2.SelectedValue == "0")
                {
                    int num1 = client.GetBrailleDots(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "- *" + "<br/>" + "* *" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "1")
                {
                    int num1 = client.GetBrailleDots(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "- -" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "2")
                {
                    int num1 = client.GetBrailleDots(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "* -" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "3")
                {
                    int num1 = client.GetBrailleDots(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "- -" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "4")
                {
                    int num1 = client.GetBrailleDots(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "- *" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "5")
                {
                    int num1 = client.GetBrailleDots(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "- *" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "6")
                {
                    int num1 = client.GetBrailleDots(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "* -" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "7")
                {
                    int num1 = client.GetBrailleDots(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "* *" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "8")
                {
                    int num1 = client.GetBrailleDots(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "* *" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "9")
                {
                    int num1 = client.GetBrailleDots(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "- *" + "<br/>" + "* -" + "<br/>" + "- -";
                }

                // Call the GetBrailleDotsLetters method in the web service and pass in the selected letter from the drop-down list
                if (CharactersDropDownList2.SelectedValue == "A")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "- -" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "B")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "* -" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "C")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "- -" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "D")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "- *" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "E")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "- *" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "F")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "* -" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "G")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "* *" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "H")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "* *" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "I")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "- *" + "<br/>" + "* -" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "J")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "- *" + "<br/>" + "* *" + "<br/>" + "- -";
                }
                if (CharactersDropDownList2.SelectedValue == "K")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "- -" + "<br/>" + "* -";
                }
                if (CharactersDropDownList2.SelectedValue == "L")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "* -" + "<br/>" + "* -";
                }
                if (CharactersDropDownList2.SelectedValue == "M")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "- -" + "<br/>" + "* -";
                }
                if (CharactersDropDownList2.SelectedValue == "N")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "- *" + "<br/>" + "* -";
                }
                if (CharactersDropDownList2.SelectedValue == "O")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "- *" + "<br/>" + "* -";
                }
                if (CharactersDropDownList2.SelectedValue == "P")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "* -" + "<br/>" + "* -";
                }
                if (CharactersDropDownList2.SelectedValue == "Q")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "* *" + "<br/>" + "* -";
                }
                if (CharactersDropDownList2.SelectedValue == "R")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "* *" + "<br/>" + "* -";
                }
                if (CharactersDropDownList2.SelectedValue == "S")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "- *" + "<br/>" + "* -" + "<br/>" + "* -";
                }
                if (CharactersDropDownList2.SelectedValue == "T")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "- *" + "<br/>" + "* *" + "<br/>" + "* -";
                }
                if (CharactersDropDownList2.SelectedValue == "U")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "- -" + "<br/>" + "* *";
                }
                if (CharactersDropDownList2.SelectedValue == "V")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "* -" + "<br/>" + "* *";
                }
                if (CharactersDropDownList2.SelectedValue == "W")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "- *" + "<br/>" + "* *" + "<br/>" + "- *";
                }
                if (CharactersDropDownList2.SelectedValue == "X")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "- -" + "<br/>" + "* *";
                }
                if (CharactersDropDownList2.SelectedValue == "Y")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* *" + "<br/>" + "- *" + "<br/>" + "* *";
                }
                if (CharactersDropDownList2.SelectedValue == "Z")
                {
                    int num1 = client.GetBrailleDotsLetters(CharactersDropDownList2.SelectedValue);
                    Label10.Text = "Number of Dots required for " + CharactersDropDownList2.SelectedValue + " = " + num1.ToString();
                    Label11.Text = "* -" + "<br/>" + "- *" + "<br/>" + "* *";
                }
            }
            Madawa.DataSource = client.GetLetters();
            Madawa.DataSource = client.GetNumbers();

            Madawa.DataBind();
        }

        protected void Madawa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}