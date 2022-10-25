namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ReceivedElectronicTenderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", IsNullable = false)]
    public partial class ReceivedElectronicTenderQuantityType : QuantityType1
    {
		public static implicit operator ReceivedElectronicTenderQuantityType(decimal val)
		{
			return new ReceivedElectronicTenderQuantityType
			{
				Value = val
			};
		}
	}
}