using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] SortExprs = null;
            SortExprs = "asd ad".Split(' ');

           var  SortExpr1s = "asd ad".Split(null);

            string result = DateTime.ParseExact("01-Aug-2016", "dd-MMM-yyyy", null).AddDays(Convert.ToInt32(15)).ToString("dd-MMM-yyyy");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loanTypeCheck.Enabled = false;
        }
    }
}