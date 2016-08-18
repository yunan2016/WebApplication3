using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
            throw new Exception("Unable to access current UserID, possible cause is session timeout. Please log out and retry your action.");
            //var a = CheckPoints.MyCheckPoints.checkpoint1;
        }

        public class CheckPoint
        {
            public string checkpoint1 { get; set; }
            public string checkpoint2 { get; set; }
            public string checkpoint3 { get; set; }
            public string checkpoint4 { get; set; }
            public string checkpoint5 { get; set; }
        }


        public static class CheckPoints
        {
            /// <summary>
            /// Global variable storing important stuff.
            /// </summary>
            static CheckPoint _myCheckpoints;

            /// <summary>
            /// Get or set the static important data.
            /// </summary>
            public static CheckPoint MyCheckPoints
            {
                get
                {
                    if (_myCheckpoints == null)
                    {
                        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["lusdMembership"].ConnectionString))
                        {
                            SqlCommand cmd = new SqlCommand("SELECT chk1, chk2, chk3, chk4, chk5 FROM checkpoints", connection);
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                CheckPoint c = new CheckPoint();
                                c.checkpoint1 = reader["chk1"].ToString();
                                c.checkpoint2 = reader["chk2"].ToString();
                                c.checkpoint3 = reader["chk3"].ToString();
                                c.checkpoint4 = reader["chk4"].ToString();
                                c.checkpoint5 = reader["chk5"].ToString();
                                _myCheckpoints = c;
                            }

                        }

                    }
                    return _myCheckpoints;
                }

            }
        }
    }
       
}