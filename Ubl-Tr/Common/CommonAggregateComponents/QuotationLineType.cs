namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("QuotationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class QuotationLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private QuantityType2 quantityField;

        private LineExtensionAmountType lineExtensionAmountField;

        private TotalTaxAmountType totalTaxAmountField;

        private RequestForQuotationLineIDType requestForQuotationLineIDField;

        private DocumentReferenceType[] documentReferenceField;

        private LineItemType lineItemField;

        private LineItemType[] sellerProposedSubstituteLineItemField;

        private LineItemType[] alternativeLineItemField;

        private LineReferenceType requestLineReferenceField;

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
        public QuantityType2 Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
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
        public TotalTaxAmountType TotalTaxAmount
        {
            get
            {
                return this.totalTaxAmountField;
            }
            set
            {
                this.totalTaxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequestForQuotationLineIDType RequestForQuotationLineID
        {
            get
            {
                return this.requestForQuotationLineIDField;
            }
            set
            {
                this.requestForQuotationLineIDField = value;
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
        public LineItemType LineItem
        {
            get
            {
                return this.lineItemField;
            }
            set
            {
                this.lineItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SellerProposedSubstituteLineItem")]
        public LineItemType[] SellerProposedSubstituteLineItem
        {
            get
            {
                return this.sellerProposedSubstituteLineItemField;
            }
            set
            {
                this.sellerProposedSubstituteLineItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlternativeLineItem")]
        public LineItemType[] AlternativeLineItem
        {
            get
            {
                return this.alternativeLineItemField;
            }
            set
            {
                this.alternativeLineItemField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType RequestLineReference
        {
            get
            {
                return this.requestLineReferenceField;
            }
            set
            {
                this.requestLineReferenceField = value;
            }
        }
    }
}