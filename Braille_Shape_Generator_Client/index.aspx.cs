using System;
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

        protected void print_circle_Click(object sender, EventArgs e)
        {
            Default_Service_Reference.Shape_Generator_ServiceSoapClient client = new Default_Service_Reference.Shape_Generator_ServiceSoapClient();
            double result = client.Circle(Convert.ToInt32(circle_radius.Text));
            circle_result.Text = result.ToString();
        }
    }
}