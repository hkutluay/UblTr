namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ItemInstance", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemInstanceType
    {

        private ProductTraceIDType productTraceIDField;

        private ManufactureDateType manufactureDateField;

        private ManufactureTimeType manufactureTimeField;

        private BestBeforeDateType bestBeforeDateField;

        private RegistrationIDType registrationIDField;

        private SerialIDType serialIDField;

        private ItemPropertyType[] additionalItemPropertyField;

        private LotIdentificationType lotIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProductTraceIDType ProductTraceID
        {
            get
            {
                return this.productTraceIDField;
            }
            set
            {
                this.productTraceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ManufactureDateType ManufactureDate
        {
            get
            {
                return this.manufactureDateField;
            }
            set
            {
                this.manufactureDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ManufactureTimeType ManufactureTime
        {
            get
            {
                return this.manufactureTimeField;
            }
            set
            {
                this.manufactureTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BestBeforeDateType BestBeforeDate
        {
            get
            {
                return this.bestBeforeDateField;
            }
            set
            {
                this.bestBeforeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationIDType RegistrationID
        {
            get
            {
                return this.registrationIDField;
            }
            set
            {
                this.registrationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SerialIDType SerialID
        {
            get
            {
                return this.serialIDField;
            }
            set
            {
                this.serialIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty")]
        public ItemPropertyType[] AdditionalItemProperty
        {
            get
            {
                return this.additionalItemPropertyField;
            }
            set
            {
                this.additionalItemPropertyField = value;
            }
        }

        /// <remarks/>
        public LotIdentificationType LotIdentification
        {
            get
            {
                return this.lotIdentificationField;
            }
            set
            {
                this.lotIdentificationField = value;
            }
        }
    }
}