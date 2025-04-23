using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
namespace FitnessWebApp
{

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEndSession_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect(Request.RawUrl, false);
            Context.ApplicationInstance.CompleteRequest();
        }

        protected void btnCalcBMI_Click(object sender, EventArgs e)
        {
            float h, w;
            if (!float.TryParse(txtHeight.Text, out h) || !float.TryParse(txtWeight.Text, out w))
            {
                lblBMIResult.Text = "Invalid input!";
                return;
            }

            // Call your ASMX service
            var client = new BMIServiceReference.BMICalculatorSoapClient();
           lblBMIResult.Text = client.CalculateBMI(h, w);
        }

        protected void btnForcePostback_Click(object sender, EventArgs e)
        {
            // Intentionally empty—forces a full page reload so you can confirm the timer value holds
        }

        protected void btnMemberPage_Click(object sender, EventArgs e)
        {
            // Redirects to your Member page (you’ll build in A6)
            Response.Redirect("~/Member.aspx");
        }

        protected void btnStaffPage_Click(object sender, EventArgs e)
        {
            // Redirects to your Staff/Admin page (you’ll build in A6)
            Response.Redirect("~/Staff.aspx");
        }


    }
}   