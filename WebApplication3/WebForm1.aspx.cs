using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // string a =dr
            for (int i = 0; i < 4; i++)
            {
                var value = (i + 1).ToString();
                DropDownList1.Items.Insert(i, new ListItem(value, value));
                DropDownList2.Items.Insert(i, new ListItem(value, value));
                DropDownList3.Items.Insert(i, new ListItem(value, value));
            }
            if (!IsPostBack)
            {
                CheckAndSetStatus();
            }
          
        }

        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetStatus();
        }
        private void CheckAndSetStatus()
        {
            if (DropDownList1.SelectedValue != null)
            {
                DropDownList2.Items.Remove(DropDownList2.Items.FindByValue(DropDownList1.SelectedValue));
                DropDownList3.Items.Remove(DropDownList3.Items.FindByValue(DropDownList1.SelectedValue));

            }

            if (DropDownList2.SelectedValue != null)
            {

                DropDownList3.Items.Remove(DropDownList3.Items.FindByValue(DropDownList2.SelectedValue));

            }
        }
    }
}