namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("OrderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class OrderLineType
    {

        private SubstitutionStatusCodeType substitutionStatusCodeField;

        private NoteType[] noteField;

        private LineItemType lineItemField;

        private LineItemType[] sellerProposedSubstituteLineItemField;

        private LineItemType[] sellerSubstitutedLineItemField;

        private LineItemType[] buyerProposedSubstituteLineItemField;

        private LineReferenceType catalogueLineReferenceField;

        private LineReferenceType quotationLineReferenceField;

        private OrderLineReferenceType[] orderLineReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubstitutionStatusCodeType SubstitutionStatusCode
        {
            get
            {
                return this.substitutionStatusCodeField;
            }
            set
            {
                this.substitutionStatusCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SellerSubstitutedLineItem")]
        public LineItemType[] SellerSubstitutedLineItem
        {
            get
            {
                return this.sellerSubstitutedLineItemField;
            }
            set
            {
                this.sellerSubstitutedLineItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BuyerProposedSubstituteLineItem")]
        public LineItemType[] BuyerProposedSubstituteLineItem
        {
            get
            {
                return this.buyerProposedSubstituteLineItemField;
            }
            set
            {
                this.buyerProposedSubstituteLineItemField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType CatalogueLineReference
        {
            get
            {
                return this.catalogueLineReferenceField;
            }
            set
            {
                this.catalogueLineReferenceField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType QuotationLineReference
        {
            get
            {
                return this.quotationLineReferenceField;
            }
            set
            {
                this.quotationLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrderLineReference")]
        public OrderLineReferenceType[] OrderLineReference
        {
            get
            {
                return this.orderLineReferenceField;
            }
            set
            {
                this.orderLineReferenceField = value;
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
    }
}