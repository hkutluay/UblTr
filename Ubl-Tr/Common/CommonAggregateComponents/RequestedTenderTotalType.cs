namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("RequestedTenderTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class RequestedTenderTotalType
    {

        private EstimatedOverallContractAmountType estimatedOverallContractAmountField;

        private TotalAmountType totalAmountField;

        private TaxIncludedIndicatorType taxIncludedIndicatorField;

        private MinimumAmountType minimumAmountField;

        private MaximumAmountType maximumAmountField;

        private MonetaryScopeType[] monetaryScopeField;

        private AverageSubsequentContractAmountType averageSubsequentContractAmountField;

        private TaxCategoryType[] applicableTaxCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedOverallContractAmountType EstimatedOverallContractAmount
        {
            get
            {
                return this.estimatedOverallContractAmountField;
            }
            set
            {
                this.estimatedOverallContractAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalAmountType TotalAmount
        {
            get
            {
                return this.totalAmountField;
            }
            set
            {
                this.totalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxIncludedIndicatorType TaxIncludedIndicator
        {
            get
            {
                return this.taxIncludedIndicatorField;
            }
            set
            {
                this.taxIncludedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumAmountType MinimumAmount
        {
            get
            {
                return this.minimumAmountField;
            }
            set
            {
                this.minimumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumAmountType MaximumAmount
        {
            get
            {
                return this.maximumAmountField;
            }
            set
            {
                this.maximumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MonetaryScope", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MonetaryScopeType[] MonetaryScope
        {
            get
            {
                return this.monetaryScopeField;
            }
            set
            {
                this.monetaryScopeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AverageSubsequentContractAmountType AverageSubsequentContractAmount
        {
            get
            {
                return this.averageSubsequentContractAmountField;
            }
            set
            {
                this.averageSubsequentContractAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory")]
        public TaxCategoryType[] ApplicableTaxCategory
        {
            get
            {
                return this.applicableTaxCategoryField;
            }
            set
            {
                this.applicableTaxCategoryField = value;
            }
        }
    }
}