using System;
using System.Web;
using System.Web.Hosting;
using System.Xml.Linq;

namespace FitnessWebApp
{
    public class Global : HttpApplication
    {
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["StartTime"] = DateTime.Now;
        }

        protected void Session_End(object sender, EventArgs e)
        {
            // Compute duration
            var start = (DateTime)Session["StartTime"];
            var end = DateTime.Now;
            var secs = (end - start).TotalSeconds;

            // Resolve App_Data path without HttpContext
            var xmlPath = HostingEnvironment.MapPath("~/App_Data/SessionLog.xml");

            // Build or append the XML
            var entry = new XElement("Session",
                new XElement("SessionID", Session.SessionID),
                new XElement("StartTime", start),
                new XElement("EndTime", end),
                new XElement("DurationSeconds", secs)
            );

            XDocument doc;
            if (System.IO.File.Exists(xmlPath))
            {
                doc = XDocument.Load(xmlPath);
                doc.Root.Add(entry);
            }
            else
            {
                doc = new XDocument(new XElement("Sessions", entry));
            }

            doc.Save(xmlPath);
        }
    }
}
