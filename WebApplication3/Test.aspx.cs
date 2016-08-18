using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
	public partial class test : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var timeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                string s = TimeZoneInfo.ConvertTime(DateTime.Now, timeZone).ToString("HH:mm:ss");

                DataTable dt = new DataTable();

                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Item"), new DataColumn("Price"), new DataColumn("Quantity") });

                dt.Rows.Add("Shirt");

                dt.Rows.Add("Football", 299, 10);

                dt.Rows.Add("Shirt", 545, 15);

                dt.Rows.Add("Disc", 99, 20);

                dt.Rows.Add("Watch", 200, 45);

                dt.Rows.Add("Clock", 670, 97);

              

            }

        }

        protected void ddl_Selected(object sender, EventArgs e)
        {


            
            DropDownList ddlLabTest = (DropDownList)sender;
            GridViewRow row = (GridViewRow)ddlLabTest.NamingContainer;
            //DataGridItem row = (DataGridItem)ddlLabTest.NamingContainer;
            DropDownList ddlAddLabTestShortName = (DropDownList)row.FindControl("ddl");

            ListBox lst = (ListBox)row.FindControl("lst");
            if (ddlAddLabTestShortName.SelectedItem.Text != "--Select--")
            {
                lst.Attributes.Add("disabled", "");
             
            }
            else
            {
                lst.Attributes.Remove("disabled");
            }

        }

        public void testFAD()
        {

            var allLines = File.ReadAllLines(@"D:\Text.txt");
          
            foreach (var line in allLines)
            {
               

            }
        }


    }
}