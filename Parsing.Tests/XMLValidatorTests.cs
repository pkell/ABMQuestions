using NUnit.Framework;
using Parsing.Tests.TestData;

namespace Parsing.Tests
{
    [TestFixture]
    class XMLValidatorTests
    {
		[TestCase("DEFAULT", "DUB", 0)]
		[TestCase("OTHER", "DUB", -1)]
		[TestCase("DEFAULT", "LIM", -2)]
		[TestCase("DE\"><", "DUB", -3)]
		public void XMLValidationReturnsExpectedCodes(string command, string siteId, int code)
		{
			Assert.That(XMLValidator.Validate(XMLStrings.xmlString(command, siteId)), Is.EqualTo(code));
		}

		[Test]
		public void XMLValidationReturnsMinusThreeIfDocumentDoesntMatchSchema()
		{
			Assert.That(XMLValidator.Validate(XMLStrings.xmlStringDoesntMatchSchema), Is.EqualTo(-3));
		}
	}

}
