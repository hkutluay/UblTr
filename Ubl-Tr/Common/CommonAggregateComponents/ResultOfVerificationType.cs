namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ResultOfVerification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ResultOfVerificationType
    {

        private ValidatorIDType validatorIDField;

        private ValidationResultCodeType validationResultCodeField;

        private ValidationDateType validationDateField;

        private ValidationTimeType validationTimeField;

        private ValidateProcessType validateProcessField;

        private ValidateToolType validateToolField;

        private ValidateToolVersionType validateToolVersionField;

        private PartyType signatoryPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidatorIDType ValidatorID
        {
            get
            {
                return this.validatorIDField;
            }
            set
            {
                this.validatorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationResultCodeType ValidationResultCode
        {
            get
            {
                return this.validationResultCodeField;
            }
            set
            {
                this.validationResultCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationDateType ValidationDate
        {
            get
            {
                return this.validationDateField;
            }
            set
            {
                this.validationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationTimeType ValidationTime
        {
            get
            {
                return this.validationTimeField;
            }
            set
            {
                this.validationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateProcessType ValidateProcess
        {
            get
            {
                return this.validateProcessField;
            }
            set
            {
                this.validateProcessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateToolType ValidateTool
        {
            get
            {
                return this.validateToolField;
            }
            set
            {
                this.validateToolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateToolVersionType ValidateToolVersion
        {
            get
            {
                return this.validateToolVersionField;
            }
            set
            {
                this.validateToolVersionField = value;
            }
        }

        /// <remarks/>
        public PartyType SignatoryParty
        {
            get
            {
                return this.signatoryPartyField;
            }
            set
            {
                this.signatoryPartyField = value;
            }
        }
    }
}