namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("MaximumPaymentInstructionsNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class MaximumPaymentInstructionsNumericType : NumericType1
    {
		public static implicit operator MaximumPaymentInstructionsNumericType(decimal val)
		{
			return new MaximumPaymentInstructionsNumericType
			{
				Value = val
			};
		}
	}
}