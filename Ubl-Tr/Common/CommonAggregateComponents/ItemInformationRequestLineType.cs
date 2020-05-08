namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ItemInformationRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemInformationRequestLineType
    {

        private TimeFrequencyCodeType timeFrequencyCodeField;

        private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

        private ForecastTypeCodeType forecastTypeCodeField;

        private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

        private PeriodType[] periodField;

        private SalesItemType[] salesItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeFrequencyCodeType TimeFrequencyCode
        {
            get
            {
                return this.timeFrequencyCodeField;
            }
            set
            {
                this.timeFrequencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode
        {
            get
            {
                return this.supplyChainActivityTypeCodeField;
            }
            set
            {
                this.supplyChainActivityTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ForecastTypeCodeType ForecastTypeCode
        {
            get
            {
                return this.forecastTypeCodeField;
            }
            set
            {
                this.forecastTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PerformanceMetricTypeCodeType PerformanceMetricTypeCode
        {
            get
            {
                return this.performanceMetricTypeCodeField;
            }
            set
            {
                this.performanceMetricTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Period")]
        public PeriodType[] Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesItem")]
        public SalesItemType[] SalesItem
        {
            get
            {
                return this.salesItemField;
            }
            set
            {
                this.salesItemField = value;
            }
        }
    }
}