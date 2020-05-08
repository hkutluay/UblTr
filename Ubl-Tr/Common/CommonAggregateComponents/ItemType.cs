namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemType
    {

        private DescriptionType descriptionField;

        private NameType1 nameField;

        private KeywordType keywordField;

        private BrandNameType brandNameField;

        private ModelNameType modelNameField;

        private ItemIdentificationType buyersItemIdentificationField;

        private ItemIdentificationType sellersItemIdentificationField;

        private ItemIdentificationType manufacturersItemIdentificationField;

        private ItemIdentificationType[] additionalItemIdentificationField;

        private CountryType originCountryField;

        private CommodityClassificationType[] commodityClassificationField;

        private ItemInstanceType[] itemInstanceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType Description
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
        public NameType1 Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public KeywordType Keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BrandNameType BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ModelNameType ModelName
        {
            get
            {
                return this.modelNameField;
            }
            set
            {
                this.modelNameField = value;
            }
        }

        /// <remarks/>
        public ItemIdentificationType BuyersItemIdentification
        {
            get
            {
                return this.buyersItemIdentificationField;
            }
            set
            {
                this.buyersItemIdentificationField = value;
            }
        }

        /// <remarks/>
        public ItemIdentificationType SellersItemIdentification
        {
            get
            {
                return this.sellersItemIdentificationField;
            }
            set
            {
                this.sellersItemIdentificationField = value;
            }
        }

        /// <remarks/>
        public ItemIdentificationType ManufacturersItemIdentification
        {
            get
            {
                return this.manufacturersItemIdentificationField;
            }
            set
            {
                this.manufacturersItemIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemIdentification")]
        public ItemIdentificationType[] AdditionalItemIdentification
        {
            get
            {
                return this.additionalItemIdentificationField;
            }
            set
            {
                this.additionalItemIdentificationField = value;
            }
        }

        /// <remarks/>
        public CountryType OriginCountry
        {
            get
            {
                return this.originCountryField;
            }
            set
            {
                this.originCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommodityClassification")]
        public CommodityClassificationType[] CommodityClassification
        {
            get
            {
                return this.commodityClassificationField;
            }
            set
            {
                this.commodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemInstance")]
        public ItemInstanceType[] ItemInstance
        {
            get
            {
                return this.itemInstanceField;
            }
            set
            {
                this.itemInstanceField = value;
            }
        }
    }
}