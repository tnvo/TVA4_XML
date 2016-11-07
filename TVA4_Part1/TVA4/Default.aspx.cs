using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace TVA4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void XMLUrlSubmitButton_Click(object sender, EventArgs e)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load(XMLUrlTextBox.Text);
            //XmlNodeList nodeList = doc.GetElementsByTagName("");
            // element(tag) names, text contents, attribute names,
            // and attribute values in the GUI page


            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(XMLUrlTextBox.Text);
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read())
                {
                    //  XMLResultLabel.Text = "The XML file results are: <BR /> <BR />";
                    XMLResultLabel.Text += "<b>Type = </b>" + reader.NodeType +
                      "<pre>Name = " + reader.Name
                    + "</pre><pre>Value = " + reader.Value +
                      "</pre><pre>Attribute Count = " + reader.AttributeCount + "</pre><br><br>";

                }

                if (reader.AttributeCount > 0)
                {
                    while (reader.MoveToNextAttribute())
                    {
                        XMLAttributeLabel.Text = "-Attribute-";
                        XMLAttributeLabel.Text = "Type = " + reader.NodeType +
                      "<br />Name = " + reader.Name
                    + "<br />Value = " + reader.Value +
                      "<br />Attribute Count = " + reader.AttributeCount + "<br><br>";

                    }
                }

            }

            catch (Exception ex)
            {
                XMLAttributeLabel.Text = "Sorry, but an error occured. Please try again and make sure that you entered a correct URL.";
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

        }
    }
}