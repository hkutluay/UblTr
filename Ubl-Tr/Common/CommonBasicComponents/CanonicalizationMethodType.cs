namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CanonicalizationMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class CanonicalizationMethodType : TextType1
    {
		public static implicit operator CanonicalizationMethodType(string val)
		{
			return new CanonicalizationMethodType
			{
				Value = val
			};
		}
	}
}