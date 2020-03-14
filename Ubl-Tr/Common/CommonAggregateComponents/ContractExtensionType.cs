namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ContractExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ContractExtensionType
    {

        private OptionsDescriptionType[] optionsDescriptionField;

        private MinimumNumberNumericType minimumNumberNumericField;

        private MaximumNumberNumericType maximumNumberNumericField;

        private PeriodType optionValidityPeriodField;

        private RenewalType[] renewalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OptionsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OptionsDescriptionType[] OptionsDescription
        {
            get
            {
                return this.optionsDescriptionField;
            }
            set
            {
                this.optionsDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumNumberNumericType MinimumNumberNumeric
        {
            get
            {
                return this.minimumNumberNumericField;
            }
            set
            {
                this.minimumNumberNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumNumberNumericType MaximumNumberNumeric
        {
            get
            {
                return this.maximumNumberNumericField;
            }
            set
            {
                this.maximumNumberNumericField = value;
            }
        }

        /// <remarks/>
        public PeriodType OptionValidityPeriod
        {
            get
            {
                return this.optionValidityPeriodField;
            }
            set
            {
                this.optionValidityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Renewal")]
        public RenewalType[] Renewal
        {
            get
            {
                return this.renewalField;
            }
            set
            {
                this.renewalField = value;
            }
        }
    }
}