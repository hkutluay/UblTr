namespace UblTr.Common
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValidationTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StartTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SourceForecastIssueTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RevisionTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResponseTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResolutionTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequiredDeliveryTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestedDespatchTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegisteredTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferenceTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaidTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OccurrenceTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NominationTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManufactureTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LatestPickupTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LatestDeliveryTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LastRevisionTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IssueTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GuaranteedDespatchTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpiryTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EstimatedDespatchTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EstimatedDeliveryTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EndTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EffectiveTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EarliestPickupTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparisonForecastIssueTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CallTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AwardTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActualPickupTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActualDespatchTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActualDeliveryTimeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class TimeType
    {

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "time")]
        public System.DateTime Value
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