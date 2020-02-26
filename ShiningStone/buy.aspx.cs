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
           
        }

        protected void ButtonSubmitOrder_Click(object sender, EventArgs e)
        {
            bool AcceptedTerms = CheckBoxAcceptTerms.Checked;
            if(AcceptedTerms == true)
            {
                Response.Write("Terms OK");
                if(Page.IsValid)
                {
                    Response.Write("Validation Okay");
                }
            }
            else
            {
                Response.Write("You must accept the terms");
            }
            string SelectedCountry = DropDownListCountry.SelectedItem.Text;
            if (SelectedCountry == "Canada")
            {
                Response.Write("We can not deliver to Canada");
            }
            else if (SelectedCountry == "United States")
            {
                Response.Write("Eligible for free delivery");
            }
            else
            {
                Response.Write("Standard delivery");
            }
        }
    }
}