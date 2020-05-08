namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("SubTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TenderLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private QuantityType2 quantityField;

        private LineExtensionAmountType lineExtensionAmountField;

        private TotalTaxAmountType totalTaxAmountField;

        private OrderableUnitType orderableUnitField;

        private ContentUnitQuantityType contentUnitQuantityField;

        private OrderQuantityIncrementNumericType orderQuantityIncrementNumericField;

        private MinimumOrderQuantityType minimumOrderQuantityField;

        private MaximumOrderQuantityType maximumOrderQuantityField;

        private WarrantyInformationType[] warrantyInformationField;

        private PackLevelCodeType packLevelCodeField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType itemField;

        private ItemLocationQuantityType[] offeredItemLocationQuantityField;

        private RelatedItemType[] replacementRelatedItemField;

        private PartyType warrantyPartyField;

        private PeriodType warrantyValidityPeriodField;

        private TenderLineType[] subTenderLineField;

        private LineReferenceType callForTendersLineReferenceField;

        private DocumentReferenceType callForTendersDocumentReferenceField;

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
        public OrderableUnitType OrderableUnit
        {
            get
            {
                return this.orderableUnitField;
            }
            set
            {
                this.orderableUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContentUnitQuantityType ContentUnitQuantity
        {
            get
            {
                return this.contentUnitQuantityField;
            }
            set
            {
                this.contentUnitQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderQuantityIncrementNumericType OrderQuantityIncrementNumeric
        {
            get
            {
                return this.orderQuantityIncrementNumericField;
            }
            set
            {
                this.orderQuantityIncrementNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumOrderQuantityType MinimumOrderQuantity
        {
            get
            {
                return this.minimumOrderQuantityField;
            }
            set
            {
                this.minimumOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumOrderQuantityType MaximumOrderQuantity
        {
            get
            {
                return this.maximumOrderQuantityField;
            }
            set
            {
                this.maximumOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WarrantyInformationType[] WarrantyInformation
        {
            get
            {
                return this.warrantyInformationField;
            }
            set
            {
                this.warrantyInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackLevelCodeType PackLevelCode
        {
            get
            {
                return this.packLevelCodeField;
            }
            set
            {
                this.packLevelCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OfferedItemLocationQuantity")]
        public ItemLocationQuantityType[] OfferedItemLocationQuantity
        {
            get
            {
                return this.offeredItemLocationQuantityField;
            }
            set
            {
                this.offeredItemLocationQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReplacementRelatedItem")]
        public RelatedItemType[] ReplacementRelatedItem
        {
            get
            {
                return this.replacementRelatedItemField;
            }
            set
            {
                this.replacementRelatedItemField = value;
            }
        }

        /// <remarks/>
        public PartyType WarrantyParty
        {
            get
            {
                return this.warrantyPartyField;
            }
            set
            {
                this.warrantyPartyField = value;
            }
        }

        /// <remarks/>
        public PeriodType WarrantyValidityPeriod
        {
            get
            {
                return this.warrantyValidityPeriodField;
            }
            set
            {
                this.warrantyValidityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubTenderLine")]
        public TenderLineType[] SubTenderLine
        {
            get
            {
                return this.subTenderLineField;
            }
            set
            {
                this.subTenderLineField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType CallForTendersLineReference
        {
            get
            {
                return this.callForTendersLineReferenceField;
            }
            set
            {
                this.callForTendersLineReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType CallForTendersDocumentReference
        {
            get
            {
                return this.callForTendersDocumentReferenceField;
            }
            set
            {
                this.callForTendersDocumentReferenceField = value;
            }
        }
    }
}