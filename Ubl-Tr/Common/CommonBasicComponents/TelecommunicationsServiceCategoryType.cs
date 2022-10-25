namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TelecommunicationsServiceCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class TelecommunicationsServiceCategoryType : TextType1
    {
		public static implicit operator TelecommunicationsServiceCategoryType(string val)
		{
			return new TelecommunicationsServiceCategoryType
			{
				Value = val
			};
		}
	}
}