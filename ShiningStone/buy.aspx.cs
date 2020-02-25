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
            //double TestDouble = 3.14159;
            //Response.Write(TestDouble * 3.14159);
            decimal TestDecimal = 3.14159m;
            Response.Write(TestDecimal * 3.14159m);
        }

        protected void ButtonSubmitOrder_Click(object sender, EventArgs e)
        {

        }
    }
}