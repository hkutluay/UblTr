namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CrewMemberPerson", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PersonType
    {

        private FirstNameType firstNameField;

        private FamilyNameType familyNameField;

        private TitleType titleField;

        private MiddleNameType middleNameField;

        private NameSuffixType nameSuffixField;

        private NationalityIDType nationalityIDField;

        private FinancialAccountType financialAccountField;

        private DocumentReferenceType identityDocumentReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FirstNameType FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FamilyNameType FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TitleType Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MiddleNameType MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameSuffixType NameSuffix
        {
            get
            {
                return this.nameSuffixField;
            }
            set
            {
                this.nameSuffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NationalityIDType NationalityID
        {
            get
            {
                return this.nationalityIDField;
            }
            set
            {
                this.nationalityIDField = value;
            }
        }

        /// <remarks/>
        public FinancialAccountType FinancialAccount
        {
            get
            {
                return this.financialAccountField;
            }
            set
            {
                this.financialAccountField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType IdentityDocumentReference
        {
            get
            {
                return this.identityDocumentReferenceField;
            }
            set
            {
                this.identityDocumentReferenceField = value;
            }
        }
    }
}