using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace _598A4TV
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        /* 5.1 - First Service - Verification
          Web operation “verification” takes the URL of an XML (.xml) file and the URL of the corresponding XMLS (.xsd) file 
          as input and validates the XML file against the corresponding XMLS (XSD) file. 
          The Web method returns “No Error” or an error message showing the available information at the error point. 
          You must use files that you created in the previous questions, with and without fault injection, as the test cases.
          However, your service operation should work for other test cases too.
          */

        private static Boolean error = false;
        private static string errorMessage;

        public string GetVerification(string xmlUrl, string xsdUrl)
        {
            errorMessage = "";
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(null, xsdUrl);
            XmlReaderSettings readerSetting = new XmlReaderSettings();
            readerSetting.ValidationType = ValidationType.Schema;
            readerSetting.Schemas = schemaSet;
            readerSetting.ValidationEventHandler += new ValidationEventHandler(validationCallback);
            XmlReader reader = XmlReader.Create(xmlUrl, readerSetting);
            error = false;
            while (reader.Read()) ;
            if (error == false)
            {
                return ("No error occured.");
            }
            return errorMessage;
        }
        private static void validationCallback(object sender, ValidationEventArgs e)
        {
            error = true;
            errorMessage += "A Validation Error Occured: " + e.Message + "\n";
        }

        /* 5.4 - XPath Search
             * Web operation “XPathSearch” takes the URL of an XML (.xml) file and 
             * a path expression as input. It returns the path expression value of the given path.
             * It could be a list of nodes, the content value, etc., depending on the path given
             */

        public string xPathSearch(string xmlUrl, string xPath)
        {
            string nodeValues = "";
            xmlUrl = xmlUrl.Replace(" ", "");
            xPath = xPath.Replace(" ", "");

            XmlDocument document = new XmlDocument();
            document.Load(xmlUrl);

            XmlNodeList nodes = document.DocumentElement.SelectNodes(xPath);

            foreach (XmlNode node in nodes)
            {
                nodeValues += (" " + node.InnerText + "\r\n" + " " + "<br />");
            }

            return nodeValues;
        }
    }
}