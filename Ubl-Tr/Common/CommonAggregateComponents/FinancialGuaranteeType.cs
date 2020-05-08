namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("FinalFinancialGuarantee", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class FinancialGuaranteeType
    {

        private GuaranteeTypeCodeType guaranteeTypeCodeField;

        private DescriptionType[] descriptionField;

        private LiabilityAmountType liabilityAmountField;

        private AmountRateType amountRateField;

        private PeriodType constitutionPeriodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GuaranteeTypeCodeType GuaranteeTypeCode
        {
            get
            {
                return this.guaranteeTypeCodeField;
            }
            set
            {
                this.guaranteeTypeCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LiabilityAmountType LiabilityAmount
        {
            get
            {
                return this.liabilityAmountField;
            }
            set
            {
                this.liabilityAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountRateType AmountRate
        {
            get
            {
                return this.amountRateField;
            }
            set
            {
                this.amountRateField = value;
            }
        }

        /// <remarks/>
        public PeriodType ConstitutionPeriod
        {
            get
            {
                return this.constitutionPeriodField;
            }
            set
            {
                this.constitutionPeriodField = value;
            }
        }
    }
}