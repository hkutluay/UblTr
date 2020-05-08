namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DutyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CallDuty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DutyType1
    {

        private AmountType2 amountField;

        private DutyType dutyField;

        private DutyCodeType dutyCodeField;

        private TaxCategoryType taxCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType2 Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DutyType Duty
        {
            get
            {
                return this.dutyField;
            }
            set
            {
                this.dutyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DutyCodeType DutyCode
        {
            get
            {
                return this.dutyCodeField;
            }
            set
            {
                this.dutyCodeField = value;
            }
        }

        /// <remarks/>
        public TaxCategoryType TaxCategory
        {
            get
            {
                return this.taxCategoryField;
            }
            set
            {
                this.taxCategoryField = value;
            }
        }
    }
}