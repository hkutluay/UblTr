namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ExtensionVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
    public partial class ExtensionVersionIDType : IdentifierType1
    {
		public static implicit operator ExtensionVersionIDType(string val)
		{
			return new ExtensionVersionIDType
			{
				Value = val
			};
		}
	}
}