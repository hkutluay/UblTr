namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("BudgetAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class BudgetAccountType
    {

        private IDType idField;

        private BudgetYearNumericType budgetYearNumericField;

        private ClassificationSchemeType requiredClassificationSchemeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BudgetYearNumericType BudgetYearNumeric
        {
            get
            {
                return this.budgetYearNumericField;
            }
            set
            {
                this.budgetYearNumericField = value;
            }
        }

        /// <remarks/>
        public ClassificationSchemeType RequiredClassificationScheme
        {
            get
            {
                return this.requiredClassificationSchemeField;
            }
            set
            {
                this.requiredClassificationSchemeField = value;
            }
        }
    }
}