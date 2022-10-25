namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PaidAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class PaidAmountType : AmountType1
    {
		public static implicit operator PaidAmountType(decimal val)
		{
			return new PaidAmountType
			{
				Value = val
			};
		}
	}
}