using UblTr.Common;

namespace UblTr.MainDoc
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2")]
    [System.Xml.Serialization.XmlRootAttribute("DespatchAdvice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2", IsNullable = false)]
    public partial class DespatchAdviceType
    {

        private UBLExtensionType[] uBLExtensionsField;

        private UBLVersionIDType uBLVersionIDField;

        private CustomizationIDType customizationIDField;

        private ProfileIDType profileIDField;

        private IDType idField;

        private CopyIndicatorType copyIndicatorField;

        private UUIDType uUIDField;

        private IssueDateType issueDateField;

        private IssueTimeType issueTimeField;

        private DespatchAdviceTypeCodeType despatchAdviceTypeCodeField;

        private NoteType[] noteField;

        private LineCountNumericType lineCountNumericField;

        private OrderReferenceType[] orderReferenceField;

        private DocumentReferenceType[] additionalDocumentReferenceField;

        private SignatureType[] signatureField;

        private SupplierPartyType despatchSupplierPartyField;

        private CustomerPartyType deliveryCustomerPartyField;

        private CustomerPartyType buyerCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private CustomerPartyType originatorCustomerPartyField;

        private ShipmentType shipmentField;

        private DespatchLineType[] despatchLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable = false)]
        public UBLExtensionType[] UBLExtensions
        {
            get
            {
                return this.uBLExtensionsField;
            }
            set
            {
                this.uBLExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UBLVersionIDType UBLVersionID
        {
            get
            {
                return this.uBLVersionIDField;
            }
            set
            {
                this.uBLVersionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomizationIDType CustomizationID
        {
            get
            {
                return this.customizationIDField;
            }
            set
            {
                this.customizationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProfileIDType ProfileID
        {
            get
            {
                return this.profileIDField;
            }
            set
            {
                this.profileIDField = value;
            }
        }

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
        public CopyIndicatorType CopyIndicator
        {
            get
            {
                return this.copyIndicatorField;
            }
            set
            {
                this.copyIndicatorField = value;
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
        public IssueDateType IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTimeType IssueTime
        {
            get
            {
                return this.issueTimeField;
            }
            set
            {
                this.issueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DespatchAdviceTypeCodeType DespatchAdviceTypeCode
        {
            get
            {
                return this.despatchAdviceTypeCodeField;
            }
            set
            {
                this.despatchAdviceTypeCodeField = value;
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
        public LineCountNumericType LineCountNumeric
        {
            get
            {
                return this.lineCountNumericField;
            }
            set
            {
                this.lineCountNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderReferenceType[] OrderReference
        {
            get
            {
                return this.orderReferenceField;
            }
            set
            {
                this.orderReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference
        {
            get
            {
                return this.additionalDocumentReferenceField;
            }
            set
            {
                this.additionalDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType DespatchSupplierParty
        {
            get
            {
                return this.despatchSupplierPartyField;
            }
            set
            {
                this.despatchSupplierPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType DeliveryCustomerParty
        {
            get
            {
                return this.deliveryCustomerPartyField;
            }
            set
            {
                this.deliveryCustomerPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                return this.buyerCustomerPartyField;
            }
            set
            {
                this.buyerCustomerPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return this.sellerSupplierPartyField;
            }
            set
            {
                this.sellerSupplierPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType OriginatorCustomerParty
        {
            get
            {
                return this.originatorCustomerPartyField;
            }
            set
            {
                this.originatorCustomerPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ShipmentType Shipment
        {
            get
            {
                return this.shipmentField;
            }
            set
            {
                this.shipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DespatchLineType[] DespatchLine
        {
            get
            {
                return this.despatchLineField;
            }
            set
            {
                this.despatchLineField = value;
            }
        }
    }
}