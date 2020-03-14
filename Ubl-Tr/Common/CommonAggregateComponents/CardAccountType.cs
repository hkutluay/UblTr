namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CardAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CardAccountType
    {

        private PrimaryAccountNumberIDType primaryAccountNumberIDField;

        private NetworkIDType networkIDField;

        private CardTypeCodeType cardTypeCodeField;

        private ValidityStartDateType validityStartDateField;

        private ExpiryDateType expiryDateField;

        private IssuerIDType issuerIDField;

        private IssueNumberIDType issueNumberIDField;

        private CV2IDType cV2IDField;

        private CardChipCodeType cardChipCodeField;

        private ChipApplicationIDType chipApplicationIDField;

        private HolderNameType holderNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrimaryAccountNumberIDType PrimaryAccountNumberID
        {
            get
            {
                return this.primaryAccountNumberIDField;
            }
            set
            {
                this.primaryAccountNumberIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetworkIDType NetworkID
        {
            get
            {
                return this.networkIDField;
            }
            set
            {
                this.networkIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CardTypeCodeType CardTypeCode
        {
            get
            {
                return this.cardTypeCodeField;
            }
            set
            {
                this.cardTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidityStartDateType ValidityStartDate
        {
            get
            {
                return this.validityStartDateField;
            }
            set
            {
                this.validityStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpiryDateType ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssuerIDType IssuerID
        {
            get
            {
                return this.issuerIDField;
            }
            set
            {
                this.issuerIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueNumberIDType IssueNumberID
        {
            get
            {
                return this.issueNumberIDField;
            }
            set
            {
                this.issueNumberIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CV2IDType CV2ID
        {
            get
            {
                return this.cV2IDField;
            }
            set
            {
                this.cV2IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CardChipCodeType CardChipCode
        {
            get
            {
                return this.cardChipCodeField;
            }
            set
            {
                this.cardChipCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChipApplicationIDType ChipApplicationID
        {
            get
            {
                return this.chipApplicationIDField;
            }
            set
            {
                this.chipApplicationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HolderNameType HolderName
        {
            get
            {
                return this.holderNameField;
            }
            set
            {
                this.holderNameField = value;
            }
        }
    }
}