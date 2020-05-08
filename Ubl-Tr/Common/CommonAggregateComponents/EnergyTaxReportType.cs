namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("EnergyTaxReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EnergyTaxReportType
    {

        private TaxEnergyAmountType taxEnergyAmountField;

        private TaxEnergyOnAccountAmountType taxEnergyOnAccountAmountField;

        private TaxEnergyBalanceAmountType taxEnergyBalanceAmountField;

        private TaxSchemeType taxSchemeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxEnergyAmountType TaxEnergyAmount
        {
            get
            {
                return this.taxEnergyAmountField;
            }
            set
            {
                this.taxEnergyAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxEnergyOnAccountAmountType TaxEnergyOnAccountAmount
        {
            get
            {
                return this.taxEnergyOnAccountAmountField;
            }
            set
            {
                this.taxEnergyOnAccountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxEnergyBalanceAmountType TaxEnergyBalanceAmount
        {
            get
            {
                return this.taxEnergyBalanceAmountField;
            }
            set
            {
                this.taxEnergyBalanceAmountField = value;
            }
        }

        /// <remarks/>
        public TaxSchemeType TaxScheme
        {
            get
            {
                return this.taxSchemeField;
            }
            set
            {
                this.taxSchemeField = value;
            }
        }
    }
}