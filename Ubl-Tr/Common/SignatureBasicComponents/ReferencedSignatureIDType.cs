namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ReferencedSignatureID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2", IsNullable = false)]
    public partial class ReferencedSignatureIDType : IdentifierType1
    {
		public static implicit operator ReferencedSignatureIDType(string val)
		{
			return new ReferencedSignatureIDType
			{
				Value = val
			};
		}
	}
}