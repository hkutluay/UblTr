namespace UblTr.Common
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetCurrencyBaseRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SourceCurrencyBaseRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RateType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderableUnitFactorRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CalculationRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AmountRateType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class RateType : NumericType
    {
		public static implicit operator RateType(decimal val)
		{
			return new RateType
			{
				Value = val
			};
		}
	}
}