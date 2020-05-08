namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ReminderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ReminderLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private UUIDType uUIDField;

        private BalanceBroughtForwardIndicatorType balanceBroughtForwardIndicatorField;

        private DebitLineAmountType debitLineAmountField;

        private CreditLineAmountType creditLineAmountField;

        private AccountingCostCodeType accountingCostCodeField;

        private AccountingCostType accountingCostField;

        private PenaltySurchargePercentType penaltySurchargePercentField;

        private AmountType2 amountField;

        private PaymentPurposeCodeType paymentPurposeCodeField;

        private PeriodType[] reminderPeriodField;

        private BillingReferenceType[] billingReferenceField;

        private ExchangeRateType exchangeRateField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUIDType UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BalanceBroughtForwardIndicatorType BalanceBroughtForwardIndicator
        {
            get
            {
                return this.balanceBroughtForwardIndicatorField;
            }
            set
            {
                this.balanceBroughtForwardIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DebitLineAmountType DebitLineAmount
        {
            get
            {
                return this.debitLineAmountField;
            }
            set
            {
                this.debitLineAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CreditLineAmountType CreditLineAmount
        {
            get
            {
                return this.creditLineAmountField;
            }
            set
            {
                this.creditLineAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostCodeType AccountingCostCode
        {
            get
            {
                return this.accountingCostCodeField;
            }
            set
            {
                this.accountingCostCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostType AccountingCost
        {
            get
            {
                return this.accountingCostField;
            }
            set
            {
                this.accountingCostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PenaltySurchargePercentType PenaltySurchargePercent
        {
            get
            {
                return this.penaltySurchargePercentField;
            }
            set
            {
                this.penaltySurchargePercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType2 Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentPurposeCodeType PaymentPurposeCode
        {
            get
            {
                return this.paymentPurposeCodeField;
            }
            set
            {
                this.paymentPurposeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReminderPeriod")]
        public PeriodType[] ReminderPeriod
        {
            get
            {
                return this.reminderPeriodField;
            }
            set
            {
                this.reminderPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
        public BillingReferenceType[] BillingReference
        {
            get
            {
                return this.billingReferenceField;
            }
            set
            {
                this.billingReferenceField = value;
            }
        }

        /// <remarks/>
        public ExchangeRateType ExchangeRate
        {
            get
            {
                return this.exchangeRateField;
            }
            set
            {
                this.exchangeRateField = value;
            }
        }
    }
}