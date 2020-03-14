namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CertificateOfOriginApplication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CertificateOfOriginApplicationType
    {

        private ReferenceIDType referenceIDField;

        private CertificateTypeType certificateTypeField;

        private ApplicationStatusCodeType applicationStatusCodeField;

        private OriginalJobIDType originalJobIDField;

        private PreviousJobIDType previousJobIDField;

        private RemarksType[] remarksField;

        private ShipmentType shipmentField;

        private EndorserPartyType[] endorserPartyField;

        private PartyType preparationPartyField;

        private PartyType issuerPartyField;

        private PartyType exporterPartyField;

        private PartyType importerPartyField;

        private CountryType issuingCountryField;

        private DocumentDistributionType[] documentDistributionField;

        private DocumentReferenceType[] supportingDocumentReferenceField;

        private SignatureType[] signatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceIDType ReferenceID
        {
            get
            {
                return this.referenceIDField;
            }
            set
            {
                this.referenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CertificateTypeType CertificateType
        {
            get
            {
                return this.certificateTypeField;
            }
            set
            {
                this.certificateTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ApplicationStatusCodeType ApplicationStatusCode
        {
            get
            {
                return this.applicationStatusCodeField;
            }
            set
            {
                this.applicationStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OriginalJobIDType OriginalJobID
        {
            get
            {
                return this.originalJobIDField;
            }
            set
            {
                this.originalJobIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousJobIDType PreviousJobID
        {
            get
            {
                return this.previousJobIDField;
            }
            set
            {
                this.previousJobIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
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
        [System.Xml.Serialization.XmlElementAttribute("EndorserParty")]
        public EndorserPartyType[] EndorserParty
        {
            get
            {
                return this.endorserPartyField;
            }
            set
            {
                this.endorserPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType PreparationParty
        {
            get
            {
                return this.preparationPartyField;
            }
            set
            {
                this.preparationPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType IssuerParty
        {
            get
            {
                return this.issuerPartyField;
            }
            set
            {
                this.issuerPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ExporterParty
        {
            get
            {
                return this.exporterPartyField;
            }
            set
            {
                this.exporterPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType ImporterParty
        {
            get
            {
                return this.importerPartyField;
            }
            set
            {
                this.importerPartyField = value;
            }
        }

        /// <remarks/>
        public CountryType IssuingCountry
        {
            get
            {
                return this.issuingCountryField;
            }
            set
            {
                this.issuingCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentDistribution")]
        public DocumentDistributionType[] DocumentDistribution
        {
            get
            {
                return this.documentDistributionField;
            }
            set
            {
                this.documentDistributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportingDocumentReference")]
        public DocumentReferenceType[] SupportingDocumentReference
        {
            get
            {
                return this.supportingDocumentReferenceField;
            }
            set
            {
                this.supportingDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Signature")]
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
    }
}