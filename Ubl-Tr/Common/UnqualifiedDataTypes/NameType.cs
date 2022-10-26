namespace UblTr.Common
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VesselNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnicalNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StreetNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RoamingPartnerNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RetailEventNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegistrationNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NameType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModelNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MiddleNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HolderNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FirstNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FileNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FamilyNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CitySubdivisionNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CityNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BuildingNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BrandNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BlockNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AliasNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdditionalStreetNameType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class NameType : TextType
    {
		public static implicit operator NameType(string val)
		{
			return new NameType
			{
				Value = val
			};
		}
	}
}