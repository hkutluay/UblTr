namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("EventTacticEnumeration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EventTacticEnumerationType
    {

        private ConsumerIncentiveTacticTypeCodeType consumerIncentiveTacticTypeCodeField;

        private DisplayTacticTypeCodeType displayTacticTypeCodeField;

        private FeatureTacticTypeCodeType featureTacticTypeCodeField;

        private TradeItemPackingLabelingTypeCodeType tradeItemPackingLabelingTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumerIncentiveTacticTypeCodeType ConsumerIncentiveTacticTypeCode
        {
            get
            {
                return this.consumerIncentiveTacticTypeCodeField;
            }
            set
            {
                this.consumerIncentiveTacticTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DisplayTacticTypeCodeType DisplayTacticTypeCode
        {
            get
            {
                return this.displayTacticTypeCodeField;
            }
            set
            {
                this.displayTacticTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FeatureTacticTypeCodeType FeatureTacticTypeCode
        {
            get
            {
                return this.featureTacticTypeCodeField;
            }
            set
            {
                this.featureTacticTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TradeItemPackingLabelingTypeCodeType TradeItemPackingLabelingTypeCode
        {
            get
            {
                return this.tradeItemPackingLabelingTypeCodeField;
            }
            set
            {
                this.tradeItemPackingLabelingTypeCodeField = value;
            }
        }
    }
}