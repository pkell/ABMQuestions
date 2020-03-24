using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Parsing
{
    public static class Parser
    {
        /// <summary>
        /// Parses out the LOC segments and adds the second and third elements to an array. 
        /// Removes the ' segment terminator.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>An array of strings containing the second and third elements of LOC segments</returns>
        public static string[] ParseLOCSegments(string message)
        {
            List<string> splitMsg = message.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();
            splitMsg.RemoveAll(el => !(el.Substring(0, 3).Equals("LOC")));
            splitMsg.ForEach( (string line) =>
            {
                var elements = line.Replace("'", "").Split('+');
                result.Add(elements[1]);
                result.Add(elements[2]);
            });
            return result.ToArray();
        }

        /// <summary>
        /// Returns the value of RefText for a given RefCode attribute on a Reference.
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="refCode"></param>
        /// <returns>RefText</returns>
        public static string GetRefText(XmlDocument doc, string refCode)
        {
            var elements = doc.GetElementsByTagName("Reference");
            var node = elements.Cast<XmlNode>()
               .Where(el => el.Attributes["RefCode"].InnerText == refCode)
               .Select(el => el.SelectSingleNode("RefText")).First();
            return node.InnerText;
        }

        /// <summary>
        /// Creates a dictionary with the three RefCodes requested in the challenge as keys.
        /// </summary>
        /// <param name="doc"></param>
        /// <returns>The dictionary</returns>
        public static Dictionary<string, string> GetRefTexts(XmlDocument doc)
        {
            return new Dictionary<string, string>
            {
                { "MWB", GetRefText(doc, "MWB") },
                { "TRV", GetRefText(doc, "TRV") },
                { "CAR", GetRefText(doc, "CAR") }
            };

        }
    }
}
