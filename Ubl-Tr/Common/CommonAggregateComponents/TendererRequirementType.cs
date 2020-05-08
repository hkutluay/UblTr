namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("SpecificTendererRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TendererRequirementType
    {

        private NameType1[] nameField;

        private TendererRequirementTypeCodeType tendererRequirementTypeCodeField;

        private DescriptionType[] descriptionField;

        private LegalReferenceType legalReferenceField;

        private EvidenceType[] suggestedEvidenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1[] Name
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
        public TendererRequirementTypeCodeType TendererRequirementTypeCode
        {
            get
            {
                return this.tendererRequirementTypeCodeField;
            }
            set
            {
                this.tendererRequirementTypeCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LegalReferenceType LegalReference
        {
            get
            {
                return this.legalReferenceField;
            }
            set
            {
                this.legalReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SuggestedEvidence")]
        public EvidenceType[] SuggestedEvidence
        {
            get
            {
                return this.suggestedEvidenceField;
            }
            set
            {
                this.suggestedEvidenceField = value;
            }
        }
    }
}