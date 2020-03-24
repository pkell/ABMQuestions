using Parsing.XML;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace Parsing
{
    public static class XMLValidator
    {
        /// <summary>
        ///  Checks if the XML document is valid i.e matches the expected payload.
        /// </summary>
        /// <param name="xml"></param>
        /// <returns>0, -1, -2 as per insturctions. -3 if document is not valid xml, doesn't match schema</returns>
        public static int Validate(string xml)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlSchemaSet schema = new XmlSchemaSet();
                schema.Add("", XmlReader.Create(new StringReader(XMLSchema.schema)));
                xmlDoc.Schemas = schema;
                xmlDoc.LoadXml(xml);

                ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
                xmlDoc.Validate(eventHandler);

                var declaration = xmlDoc.GetElementsByTagName("Declaration")[0];
                var siteID = xmlDoc.GetElementsByTagName("SiteID")[0];

                if (!declaration.Attributes["Command"].Value.Equals("DEFAULT")) return -1;
                else if (!siteID.InnerText.Equals("DUB")) return -2;
                return 0;
            }
            catch (XmlException) {
                return -3;
            }
        }

        /// <summary>
        /// Throws an exception if the xml document being validated is invalid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error) throw new XmlException("Document is not valid");

        }
    }
}
