
namespace Parsing.Tests.TestData
{
    public static class XMLStrings
    {
		public static string xmlString(string command, string siteId) => $@"
<InputDocument>
	<DeclarationList>
		<Declaration Command=""{command}"" Version=""5.13"">
			<DeclarationHeader>
				<Jurisdiction>IE</Jurisdiction>
				<CWProcedure>IMPORT</CWProcedure>
							<DeclarationDestination>CUSTOMSWAREIE</DeclarationDestination>
				<DocumentRef>71Q0019681</DocumentRef>
				<SiteID>{siteId}</SiteID>
				<AccountCode>G0779837</AccountCode>
			</DeclarationHeader>
		</Declaration>
	</DeclarationList>
</InputDocument>
";

		public static readonly string xmlStringMatchesSchema = $@"
<InputDocument>
	<DeclarationList>
		<Declaration Command=""DEFAULT"" Version=""5.13"">
			<DeclarationHeader>
				<Jurisdiction>IE</Jurisdiction>
				<CWProcedure>EXPORT</CWProcedure>
							<DeclarationDestination>CUSTOMSTWO</DeclarationDestination>
				<DocumentRef>41T0319781</DocumentRef>
				<SiteID>DUB</SiteID>
				<AccountCode>F2379539</AccountCode>
			</DeclarationHeader>
		</Declaration>
	</DeclarationList>
</InputDocument>
";

		public static readonly string xmlStringDoesntMatchSchema = $@"
<InputDoc>
		<Declaration Command=""DEFAULT"" Version=""5.13"">
			<DeclarationHeader>
				<Jurisdiction>IE</Jurisdiction>
				<CWProcedure>EXPORT</CWProcedure>
							<DeclarationDestination>CUSTOMSTWO</DeclarationDestination>
				<DocumentRef>41T0319781</DocumentRef>
				<SiteID>DUB</SiteID>
				<AccountCode>F2379539</AccountCode>
			</DeclarationHeader>
		</Declaration>
</InputDoc>
";

        public static readonly string challengeTwoXml = @"<InputDocument>
  <DeclarationList>
    <Declaration Command=""DEFAULT"" Version=""5.13"">
      <DeclarationHeader>
        <Jurisdiction>IE</Jurisdiction>
        <CWProcedure>IMPORT</CWProcedure>
        <DeclarationDestination>CUSTOMSWAREIE</DeclarationDestination>
        <DocumentRef>71Q0019681</DocumentRef>
        <SiteID>DUB</SiteID>
        <AccountCode>G0779837</AccountCode>
        <Reference RefCode=""MWB"">
          <RefText>586133622</RefText>
        </Reference>
        <Reference RefCode=""KEY"">
          <RefText>DUB16049</RefText>
        </Reference>
        <Reference RefCode=""CAR"">
          <RefText>71Q0019681</RefText>
        </Reference>
        <Reference RefCode=""COM"">
          <RefText>71Q0019681</RefText>
        </Reference>
        <Reference RefCode=""SRC"">
          <RefText>ECUS</RefText>
        </Reference>
        <Reference RefCode=""TRV"">
          <RefText>1</RefText>
        </Reference>
        <Reference RefCode=""CAS"">
          <RefText>586133622</RefText>
        </Reference>
        <Reference RefCode=""HWB"">
          <RefText>586133622</RefText>
        </Reference>
        <Reference RefCode=""UCR"">
          <RefText>586133622</RefText>
        </Reference>
        <Country CodeType=""NUM"" CountryType=""Destination"">IE</Country>
        <Country CodeType=""NUM"" CountryType=""Dispatch"">CN</Country>
          </DeclarationHeader>
</Declaration>
</DeclarationList>
</InputDocument>
            ";
    }
}
