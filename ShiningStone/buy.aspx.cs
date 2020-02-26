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
            AcceptedTerms = true;
        }

        private bool AcceptedTerms
        {
            get
            {
                return CheckBoxAcceptTerms.Checked;
            }
            set
            {
                CheckBoxAcceptTerms.Checked = value;
            }
        }

        protected void ButtonSubmitOrder_Click(object sender, EventArgs e)
        {
            string SelectedCountry = DropDownListCountry.SelectedItem.Text;
            if (
                (Page.IsValid && CheckBoxAcceptTerms.Checked)
                && 
                (SelectedCountry == "United States"|| SelectedCountry == "Mexico")
                )
            {
                Response.Write("Logic Succeeded");
            }
        }
    }
}