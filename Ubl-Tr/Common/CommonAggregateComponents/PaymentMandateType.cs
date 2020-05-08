namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PaymentMandate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PaymentMandateType
    {

        private IDType idField;

        private MandateTypeCodeType mandateTypeCodeField;

        private MaximumPaymentInstructionsNumericType maximumPaymentInstructionsNumericField;

        private MaximumPaidAmountType maximumPaidAmountField;

        private SignatureIDType signatureIDField;

        private PartyType payerPartyField;

        private FinancialAccountType payerFinancialAccountField;

        private PeriodType validityPeriodField;

        private PeriodType paymentReversalPeriodField;

        private ClauseType[] clauseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MandateTypeCodeType MandateTypeCode
        {
            get
            {
                return this.mandateTypeCodeField;
            }
            set
            {
                this.mandateTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumPaymentInstructionsNumericType MaximumPaymentInstructionsNumeric
        {
            get
            {
                return this.maximumPaymentInstructionsNumericField;
            }
            set
            {
                this.maximumPaymentInstructionsNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumPaidAmountType MaximumPaidAmount
        {
            get
            {
                return this.maximumPaidAmountField;
            }
            set
            {
                this.maximumPaidAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SignatureIDType SignatureID
        {
            get
            {
                return this.signatureIDField;
            }
            set
            {
                this.signatureIDField = value;
            }
        }

        /// <remarks/>
        public PartyType PayerParty
        {
            get
            {
                return this.payerPartyField;
            }
            set
            {
                this.payerPartyField = value;
            }
        }

        /// <remarks/>
        public FinancialAccountType PayerFinancialAccount
        {
            get
            {
                return this.payerFinancialAccountField;
            }
            set
            {
                this.payerFinancialAccountField = value;
            }
        }

        /// <remarks/>
        public PeriodType ValidityPeriod
        {
            get
            {
                return this.validityPeriodField;
            }
            set
            {
                this.validityPeriodField = value;
            }
        }

        /// <remarks/>
        public PeriodType PaymentReversalPeriod
        {
            get
            {
                return this.paymentReversalPeriodField;
            }
            set
            {
                this.paymentReversalPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Clause")]
        public ClauseType[] Clause
        {
            get
            {
                return this.clauseField;
            }
            set
            {
                this.clauseField = value;
            }
        }
    }
}