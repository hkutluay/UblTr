namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("DocumentDistribution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DocumentDistributionType
    {

        private PrintQualifierType printQualifierField;

        private MaximumCopiesNumericType maximumCopiesNumericField;

        private PartyType partyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrintQualifierType PrintQualifier
        {
            get
            {
                return this.printQualifierField;
            }
            set
            {
                this.printQualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumCopiesNumericType MaximumCopiesNumeric
        {
            get
            {
                return this.maximumCopiesNumericField;
            }
            set
            {
                this.maximumCopiesNumericField = value;
            }
        }

        /// <remarks/>
        public PartyType Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }
}