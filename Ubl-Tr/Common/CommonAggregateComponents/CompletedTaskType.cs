namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CompletedTask", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CompletedTaskType
    {

        private AnnualAverageAmountType annualAverageAmountField;

        private TotalTaskAmountType totalTaskAmountField;

        private PartyCapacityAmountType partyCapacityAmountField;

        private DescriptionType[] descriptionField;

        private EvidenceSuppliedType[] evidenceSuppliedField;

        private PeriodType periodField;

        private CustomerPartyType recipientCustomerPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AnnualAverageAmountType AnnualAverageAmount
        {
            get
            {
                return this.annualAverageAmountField;
            }
            set
            {
                this.annualAverageAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalTaskAmountType TotalTaskAmount
        {
            get
            {
                return this.totalTaskAmountField;
            }
            set
            {
                this.totalTaskAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PartyCapacityAmountType PartyCapacityAmount
        {
            get
            {
                return this.partyCapacityAmountField;
            }
            set
            {
                this.partyCapacityAmountField = value;
            }
        }

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
        [System.Xml.Serialization.XmlElementAttribute("EvidenceSupplied")]
        public EvidenceSuppliedType[] EvidenceSupplied
        {
            get
            {
                return this.evidenceSuppliedField;
            }
            set
            {
                this.evidenceSuppliedField = value;
            }
        }

        /// <remarks/>
        public PeriodType Period
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
        public CustomerPartyType RecipientCustomerParty
        {
            get
            {
                return this.recipientCustomerPartyField;
            }
            set
            {
                this.recipientCustomerPartyField = value;
            }
        }
    }
}