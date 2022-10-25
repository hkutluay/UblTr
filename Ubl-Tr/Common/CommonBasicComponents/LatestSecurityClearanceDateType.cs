namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("LatestSecurityClearanceDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class LatestSecurityClearanceDateType : DateType
    {
		public static implicit operator LatestSecurityClearanceDateType(System.DateTime val)
		{
			return new LatestSecurityClearanceDateType
			{
				Value = val
			};
		}
	}
}