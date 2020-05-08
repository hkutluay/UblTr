namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("DeliveryUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DeliveryUnitType
    {

        private BatchQuantityType batchQuantityField;

        private ConsumerUnitQuantityType consumerUnitQuantityField;

        private HazardousRiskIndicatorType hazardousRiskIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BatchQuantityType BatchQuantity
        {
            get
            {
                return this.batchQuantityField;
            }
            set
            {
                this.batchQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumerUnitQuantityType ConsumerUnitQuantity
        {
            get
            {
                return this.consumerUnitQuantityField;
            }
            set
            {
                this.consumerUnitQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return this.hazardousRiskIndicatorField;
            }
            set
            {
                this.hazardousRiskIndicatorField = value;
            }
        }
    }
}