namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("SupplierConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class SupplierConsumptionType
    {

        private DescriptionType[] descriptionField;

        private PartyType utilitySupplierPartyField;

        private PartyType utilityCustomerPartyField;

        private ConsumptionType consumptionField;

        private ContractType contractField;

        private ConsumptionLineType[] consumptionLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public PartyType UtilitySupplierParty
        {
            get
            {
                return this.utilitySupplierPartyField;
            }
            set
            {
                this.utilitySupplierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType UtilityCustomerParty
        {
            get
            {
                return this.utilityCustomerPartyField;
            }
            set
            {
                this.utilityCustomerPartyField = value;
            }
        }

        /// <remarks/>
        public ConsumptionType Consumption
        {
            get
            {
                return this.consumptionField;
            }
            set
            {
                this.consumptionField = value;
            }
        }

        /// <remarks/>
        public ContractType Contract
        {
            get
            {
                return this.contractField;
            }
            set
            {
                this.contractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionLine")]
        public ConsumptionLineType[] ConsumptionLine
        {
            get
            {
                return this.consumptionLineField;
            }
            set
            {
                this.consumptionLineField = value;
            }
        }
    }
}