namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AuctionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AuctionTermsType
    {

        private AuctionConstraintIndicatorType auctionConstraintIndicatorField;

        private JustificationDescriptionType[] justificationDescriptionField;

        private DescriptionType[] descriptionField;

        private ProcessDescriptionType[] processDescriptionField;

        private ConditionsDescriptionType[] conditionsDescriptionField;

        private ElectronicDeviceDescriptionType[] electronicDeviceDescriptionField;

        private AuctionURIType auctionURIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AuctionConstraintIndicatorType AuctionConstraintIndicator
        {
            get
            {
                return this.auctionConstraintIndicatorField;
            }
            set
            {
                this.auctionConstraintIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JustificationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public JustificationDescriptionType[] JustificationDescription
        {
            get
            {
                return this.justificationDescriptionField;
            }
            set
            {
                this.justificationDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProcessDescriptionType[] ProcessDescription
        {
            get
            {
                return this.processDescriptionField;
            }
            set
            {
                this.processDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConditionsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConditionsDescriptionType[] ConditionsDescription
        {
            get
            {
                return this.conditionsDescriptionField;
            }
            set
            {
                this.conditionsDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElectronicDeviceDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ElectronicDeviceDescriptionType[] ElectronicDeviceDescription
        {
            get
            {
                return this.electronicDeviceDescriptionField;
            }
            set
            {
                this.electronicDeviceDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AuctionURIType AuctionURI
        {
            get
            {
                return this.auctionURIField;
            }
            set
            {
                this.auctionURIField = value;
            }
        }
    }
}