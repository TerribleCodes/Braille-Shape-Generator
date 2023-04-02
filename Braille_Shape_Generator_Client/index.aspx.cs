﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                - [ ] Generating the patterns (Implementing the algorithms)
             */
            // COMPLETED 1st 3 tasks by Madawa De Silva on 04.02.2023@8:42PM


            Label10.Text = EnterHeight.Text + EnterRadius.Text + EnterWidth.Text + shape_drop_down.Text; ;
            ShapeGeneratorService.Shape_Generator_ServiceSoapClient client = new ShapeGeneratorService.Shape_Generator_ServiceSoapClient();

            // Square
            if (shape_drop_down.Text == "square")
            {
                double result = client.Square(Convert.ToDouble(EnterHeight.Text));
                Label10.Text = "Number of dots required for the Square: "+result.ToString();  
                // Implement the square generating algorithm 
            }

            // Rectangle
            if (shape_drop_down.Text == "rectangle")
            {
                double result = client.Rectangle(Convert.ToDouble(EnterHeight.Text), Convert.ToDouble(EnterWidth.Text));
                Label10.Text = "Number of dots required for the Rectangle: " + result.ToString();
                // Implement the rectangle generating algorithm 
            }
            

            // Triangle
            if (shape_drop_down.Text == "triangle")
            {
                double result = client.Triangle(Convert.ToDouble(EnterHeight.Text), Convert.ToDouble(EnterWidth.Text));
                Label10.Text = "Number of dots required for the Triangle: "+result.ToString();  
                // Implement the Triangle generating algorithm 
            }   
            
            
            // Circle
            if (shape_drop_down.Text == "circle")
            {
                double result = client.Circle(Convert.ToDouble(EnterRadius.Text));
                Label10.Text = "Number of dots required for the Circle: "+result.ToString();  
                // Implement the circle generating algorithm 
            }

            if (shape_drop_down.Text == "select")
            {
                Label10.Text = "Please select a shape or a Character";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Label10.Text = "This is the character generating section :D";
        }
    }
}