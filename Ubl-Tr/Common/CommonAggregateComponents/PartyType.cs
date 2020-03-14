namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalInformationParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PartyType
    {

        private WebsiteURIType websiteURIField;

        private EndpointIDType endpointIDField;

        private IndustryClassificationCodeType industryClassificationCodeField;

        private PartyIdentificationType[] partyIdentificationField;

        private PartyNameType partyNameField;

        private AddressType postalAddressField;

        private LocationType1 physicalLocationField;

        private PartyTaxSchemeType partyTaxSchemeField;

        private PartyLegalEntityType[] partyLegalEntityField;

        private ContactType contactField;

        private PersonType personField;

        private PartyType agentPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WebsiteURIType WebsiteURI
        {
            get
            {
                return this.websiteURIField;
            }
            set
            {
                this.websiteURIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EndpointIDType EndpointID
        {
            get
            {
                return this.endpointIDField;
            }
            set
            {
                this.endpointIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndustryClassificationCodeType IndustryClassificationCode
        {
            get
            {
                return this.industryClassificationCodeField;
            }
            set
            {
                this.industryClassificationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyIdentification")]
        public PartyIdentificationType[] PartyIdentification
        {
            get
            {
                return this.partyIdentificationField;
            }
            set
            {
                this.partyIdentificationField = value;
            }
        }

        /// <remarks/>
        public PartyNameType PartyName
        {
            get
            {
                return this.partyNameField;
            }
            set
            {
                this.partyNameField = value;
            }
        }

        /// <remarks/>
        public AddressType PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                this.postalAddressField = value;
            }
        }

        /// <remarks/>
        public LocationType1 PhysicalLocation
        {
            get
            {
                return this.physicalLocationField;
            }
            set
            {
                this.physicalLocationField = value;
            }
        }

        /// <remarks/>
        public PartyTaxSchemeType PartyTaxScheme
        {
            get
            {
                return this.partyTaxSchemeField;
            }
            set
            {
                this.partyTaxSchemeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyLegalEntity")]
        public PartyLegalEntityType[] PartyLegalEntity
        {
            get
            {
                return this.partyLegalEntityField;
            }
            set
            {
                this.partyLegalEntityField = value;
            }
        }

        /// <remarks/>
        public ContactType Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public PersonType Person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }

        /// <remarks/>
        public PartyType AgentParty
        {
            get
            {
                return this.agentPartyField;
            }
            set
            {
                this.agentPartyField = value;
            }
        }
    }
}