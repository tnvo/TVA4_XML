using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _598A4TV
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetVerificationButton_Click(object sender, EventArgs e)
        {
           
            A4.Service1Client verificationClient = new A4.Service1Client();

            try
            {
                VerificationResultLabel.Text = verificationClient.GetVerification(xmlUrlTextBox2.Text, XSDTextBox.Text);
            }
            catch (Exception ex)
            {
                VerificationResultLabel.Text = "Sorry, an error occured. The error is: <br /> " + ex.ToString();
            }
            finally
            {
                verificationClient.Close();
            }
        }

        protected void GetXPathButton_Click(object sender, EventArgs e)
        {
            A4.Service1Client xPathClient = new A4.Service1Client();

            try
            {
                XPathResultLabel.Text = xPathClient.xPathSearch(XmlTextBox3.Text, XPathTextBox.Text);
            }
            catch (Exception ex)
            {
                XPathResultLabel.Text = "Sorry, an error occured. The error is: <br /> " + ex.ToString();
            }
            finally
            {
                xPathClient.Close();
            }
        }
    }
}