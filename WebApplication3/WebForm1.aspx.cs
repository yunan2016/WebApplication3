using HtmlAgilityPack;
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
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            string sampleHtml =
                "<html>" +
                    "<head>" +
                            "<script type=\"text/javascript\" src=\"jquery.js\"></script>" +
                            "<script type=\"text/javascript\">" +
                                "if (window.self === window.top) { $.getScript(\"Wing.js\"); }" +
                            "</script>" +
                    "</head>" +"<body>"+"adsasd"+"</body>"+
                "</html>";
            MemoryStream ms = new MemoryStream(Encoding.ASCII.GetBytes(sampleHtml));
          
            doc.Load(ms);
            HtmlNode head = doc.DocumentNode.SelectSingleNode("/html/head");
            head.Remove();
            //List<HtmlNode> nodes = new List<HtmlNode>(doc.DocumentNode.Descendants("head"));
            //int childNodeCount = nodes[0].ChildNodes.Count;
            //for (int i = 0; i < childNodeCount; i++)
            //    nodes[0].ChildNodes.Remove(0);
           Response.Write(doc.DocumentNode.OuterHtml);
        }


       

        [System.Web.Services.WebMethod]
        public static string GetUsername(string name)
        {
            return "Hello " + name ;
        }
    }
    public class Video_Downloader_DLL
    {
        public void VideoDownloader()
        {
        }

      
    }

    public class Employee
    {
        public int id;
        public string name;
    }

    public class Student
    {
        public int Stuid;
        public string Stuname;
    }
}