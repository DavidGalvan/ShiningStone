﻿using System;
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
            string PhoneNumberText = TextBoxPhoneNumber.Text;
            //int PhoneNumber = Convert.ToInt32(PhoneNumberText);
            int PhoneNumber = int.Parse(PhoneNumberText);
            //float PhoneNumberFloat = Convert.ToSingle(PhoneNumber);
            float PhoneNumberFloat = float.Parse(PhoneNumberText);
        }
    }
}