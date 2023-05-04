﻿using System;
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
                Label11.Text = "";
            }

            // Rectangle
            if (shape_drop_down.Text == "rectangle")
            {
                double result = client.Rectangle(Convert.ToDouble(EnterHeight.Text), Convert.ToDouble(EnterWidth.Text));
                Label10.Text = "Number of dots required for the Rectangle: " + result.ToString();
                Label11.Text = "";
            }
            

            // Triangle
            if (shape_drop_down.Text == "triangle")
            {
                double result = client.Triangle(Convert.ToDouble(EnterHeight.Text), Convert.ToDouble(EnterWidth.Text));
                Label10.Text = "Number of dots required for the Triangle: "+result.ToString();
                Label11.Text = "";
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
               - [ ] Generating the braille numbers
            */
            // COMPLETED 1st 2 tasks by Himasha Gayathri on 04/06/2023

            ShapeGeneratorService.Shape_Generator_ServiceSoapClient client = new ShapeGeneratorService.Shape_Generator_ServiceSoapClient();
            string selectedNumber = CharactersDropDownList2.SelectedValue;
            // Call the GetBrailleDots method in the web service and pass in the selected number from the drop-down list
            int num = client.GetBrailleDots(selectedNumber);
            Label10.Text = "Number of Dots required for "+selectedNumber+" = "+num.ToString();
            
            // Hima's part. Continue the number generator. Change the characters if necessary idk.
            if (selectedNumber=="0")
            {
                Label11.Text = "**"+ "<br/>" + "--" + "<br/>" +"**";
            }


            ShapeGeneratorService.Shape_Generator_ServiceSoapClient client1 = new ShapeGeneratorService.Shape_Generator_ServiceSoapClient();
            string selectedLetter = CharactersDropDownList2.SelectedValue;
            // Call the GetBrailleDotsLetters method in the web service and pass in the selected number from the drop-down list
            int num1 = client.GetBrailleDotsLetters(selectedLetter);
            Label10.Text = "Number of Dots required for "+selectedLetter+ " = " + num1.ToString();
            // Nalitha start from here. Same approach.


            
            Madawa.DataSource = client1.GetLetters();
            Madawa.DataSource = client1.GetNumbers();
            
            Madawa.DataBind();
        }

        protected void Madawa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}