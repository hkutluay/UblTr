namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CatalogueLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CatalogueLineType
    {

        private IDType idField;

        private ActionCodeType actionCodeField;

        private LifeCycleStatusCodeType lifeCycleStatusCodeField;

        private ContractSubdivisionType contractSubdivisionField;

        private NoteType[] noteField;

        private OrderableIndicatorType orderableIndicatorField;

        private OrderableUnitType orderableUnitField;

        private ContentUnitQuantityType contentUnitQuantityField;

        private OrderQuantityIncrementNumericType orderQuantityIncrementNumericField;

        private MinimumOrderQuantityType minimumOrderQuantityField;

        private MaximumOrderQuantityType maximumOrderQuantityField;

        private WarrantyInformationType[] warrantyInformationField;

        private PackLevelCodeType packLevelCodeField;

        private CustomerPartyType contractorCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private PartyType warrantyPartyField;

        private PeriodType warrantyValidityPeriodField;

        private PeriodType lineValidityPeriodField;

        private ItemComparisonType[] itemComparisonField;

        private RelatedItemType[] componentRelatedItemField;

        private RelatedItemType[] accessoryRelatedItemField;

        private RelatedItemType[] requiredRelatedItemField;

        private RelatedItemType[] replacementRelatedItemField;

        private RelatedItemType[] complementaryRelatedItemField;

        private RelatedItemType[] replacedRelatedItemField;

        private ItemLocationQuantityType[] requiredItemLocationQuantityField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType itemField;

        private ItemPropertyType[] keywordItemPropertyField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActionCodeType ActionCode
        {
            get
            {
                return this.actionCodeField;
            }
            set
            {
                this.actionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LifeCycleStatusCodeType LifeCycleStatusCode
        {
            get
            {
                return this.lifeCycleStatusCodeField;
            }
            set
            {
                this.lifeCycleStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractSubdivisionType ContractSubdivision
        {
            get
            {
                return this.contractSubdivisionField;
            }
            set
            {
                this.contractSubdivisionField = value;
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
        public OrderableIndicatorType OrderableIndicator
        {
            get
            {
                return this.orderableIndicatorField;
            }
            set
            {
                this.orderableIndicatorField = value;
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
        public CustomerPartyType ContractorCustomerParty
        {
            get
            {
                return this.contractorCustomerPartyField;
            }
            set
            {
                this.contractorCustomerPartyField = value;
            }
        }

        /// <remarks/>
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
        public PeriodType LineValidityPeriod
        {
            get
            {
                return this.lineValidityPeriodField;
            }
            set
            {
                this.lineValidityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemComparison")]
        public ItemComparisonType[] ItemComparison
        {
            get
            {
                return this.itemComparisonField;
            }
            set
            {
                this.itemComparisonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComponentRelatedItem")]
        public RelatedItemType[] ComponentRelatedItem
        {
            get
            {
                return this.componentRelatedItemField;
            }
            set
            {
                this.componentRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccessoryRelatedItem")]
        public RelatedItemType[] AccessoryRelatedItem
        {
            get
            {
                return this.accessoryRelatedItemField;
            }
            set
            {
                this.accessoryRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredRelatedItem")]
        public RelatedItemType[] RequiredRelatedItem
        {
            get
            {
                return this.requiredRelatedItemField;
            }
            set
            {
                this.requiredRelatedItemField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ComplementaryRelatedItem")]
        public RelatedItemType[] ComplementaryRelatedItem
        {
            get
            {
                return this.complementaryRelatedItemField;
            }
            set
            {
                this.complementaryRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReplacedRelatedItem")]
        public RelatedItemType[] ReplacedRelatedItem
        {
            get
            {
                return this.replacedRelatedItemField;
            }
            set
            {
                this.replacedRelatedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity")]
        public ItemLocationQuantityType[] RequiredItemLocationQuantity
        {
            get
            {
                return this.requiredItemLocationQuantityField;
            }
            set
            {
                this.requiredItemLocationQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("KeywordItemProperty")]
        public ItemPropertyType[] KeywordItemProperty
        {
            get
            {
                return this.keywordItemPropertyField;
            }
            set
            {
                this.keywordItemPropertyField = value;
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