﻿
namespace Parsing.XML
{
    public static class XMLSchema
    {
        public static readonly string schema = @"
<xs:schema attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""InputDocument"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""DeclarationList"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Declaration"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name = ""DeclarationHeader"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element type=""xs:string"" name=""Jurisdiction""/>
                          <xs:element type=""xs:string"" name=""CWProcedure""/>
                          <xs:element type=""xs:string"" name=""DeclarationDestination""/>
                          <xs:element type=""xs:string"" name=""DocumentRef""/>
                          <xs:element type=""xs:string"" name=""SiteID""/>
                          <xs:element type=""xs:string"" name=""AccountCode""/>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                  <xs:attribute type=""xs:string"" name=""Command""/>
                  <xs:attribute type=""xs:float"" name=""Version""/>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
    }
}