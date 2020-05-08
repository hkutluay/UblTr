namespace UblTr.Common
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetCurrencyBaseRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SourceCurrencyBaseRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RateType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderableUnitFactorRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CalculationRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AmountRateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TierRatePercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetServicePercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SettlementDiscountPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReliabilityPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProgressPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PercentType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PenaltySurchargePercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParticipationPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartecipationPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinimumPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HumidityPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AirFlowPercentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NumericType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeightNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SequenceNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResidentOccupantsNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReminderSequenceNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PackSizeNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderQuantityIncrementNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderIntervalDaysNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiplierFactorNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinimumNumberNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumPaymentInstructionsNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumNumberNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumCopiesNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineNumberNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineCountNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrozenPeriodDaysNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CalculationSequenceNumericType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetYearNumericType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class NumericType
    {

        private string formatField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}