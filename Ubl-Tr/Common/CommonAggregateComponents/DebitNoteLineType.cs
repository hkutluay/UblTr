namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("DebitNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DebitNoteLineType
    {

        private IDType idField;

        private UUIDType uUIDField;

        private NoteType[] noteField;

        private DebitedQuantityType debitedQuantityField;

        private LineExtensionAmountType lineExtensionAmountField;

        private TaxPointDateType taxPointDateField;

        private AccountingCostCodeType accountingCostCodeField;

        private AccountingCostType accountingCostField;

        private PaymentPurposeCodeType paymentPurposeCodeField;

        private ResponseType[] discrepancyResponseField;

        private LineReferenceType[] despatchLineReferenceField;

        private LineReferenceType[] receiptLineReferenceField;

        private BillingReferenceType[] billingReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private PricingReferenceType pricingReferenceField;

        private DeliveryType[] deliveryField;

        private TaxTotalType[] taxTotalField;

        private AllowanceChargeType[] allowanceChargeField;

        private ItemType itemField;

        private PriceType priceField;

        private DebitNoteLineType[] subDebitNoteLineField;

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
        public DebitedQuantityType DebitedQuantity
        {
            get
            {
                return this.debitedQuantityField;
            }
            set
            {
                this.debitedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmountType LineExtensionAmount
        {
            get
            {
                return this.lineExtensionAmountField;
            }
            set
            {
                this.lineExtensionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxPointDateType TaxPointDate
        {
            get
            {
                return this.taxPointDateField;
            }
            set
            {
                this.taxPointDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse")]
        public ResponseType[] DiscrepancyResponse
        {
            get
            {
                return this.discrepancyResponseField;
            }
            set
            {
                this.discrepancyResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference")]
        public LineReferenceType[] DespatchLineReference
        {
            get
            {
                return this.despatchLineReferenceField;
            }
            set
            {
                this.despatchLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptLineReference")]
        public LineReferenceType[] ReceiptLineReference
        {
            get
            {
                return this.receiptLineReferenceField;
            }
            set
            {
                this.receiptLineReferenceField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        public PricingReferenceType PricingReference
        {
            get
            {
                return this.pricingReferenceField;
            }
            set
            {
                this.pricingReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Delivery")]
        public DeliveryType[] Delivery
        {
            get
            {
                return this.deliveryField;
            }
            set
            {
                this.deliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return this.taxTotalField;
            }
            set
            {
                this.taxTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
            }
        }

        /// <remarks/>
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public PriceType Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubDebitNoteLine")]
        public DebitNoteLineType[] SubDebitNoteLine
        {
            get
            {
                return this.subDebitNoteLineField;
            }
            set
            {
                this.subDebitNoteLineField = value;
            }
        }
    }
}