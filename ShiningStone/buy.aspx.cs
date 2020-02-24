using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShiningStone
{
    public partial class buy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string TestString = "Hello World";
            //TestString = "Please Enter address";
            //TextBoxAddress1.Text = TestString;


        }

        protected void ButtonSubmitOrder_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Write("OK");
            }

            //string Address1 = TextBoxAddress1.Text;
            //Response.Write(Address1);
            string Address1 = TextBoxAddress1.Text;
            Response.Write(Address1);
        }
    }
}