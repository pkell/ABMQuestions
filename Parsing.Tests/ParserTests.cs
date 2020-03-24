using NUnit.Framework;
using Parsing.Tests.TestData;
using System.Collections.Generic;
using System.Xml;

namespace Parsing.Tests
{
    [TestFixture]
    public class ParserTests
    {
        [Test]
        public void LOCParsingReturnsArrayWithSecondThirdElements()
        {
            string[] expected = new string[] { "17", "IT044100", "18", "SOL", "35", "SE", "36", "TZ", "116", "SE003033" };

            Assert.AreEqual(expected, Parser.ParseLOCSegments(EdifactMessages.msg));
        }

        [TestCase("MWB", "586133622")]
        [TestCase("TRV", "1")]
        [TestCase("CAR", "71Q0019681")]
        public void ReturnRefTextForCode(string refCode, string refText)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XMLStrings.challengeTwoXml);
            Assert.That(Parser.GetRefText(doc, refCode), Is.EqualTo(refText));
        }

        [Test]
        public void ReturnRefTextsForThreeRequiredCodes()
        {
            Dictionary<string, string> expected = new Dictionary<string, string>
            {
                { "MWB", "586133622" },
                { "TRV", "1" },
                { "CAR", "71Q0019681" }
            };
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XMLStrings.challengeTwoXml);
            Assert.AreEqual(expected, Parser.GetRefTexts(doc));
        }
    }
}
