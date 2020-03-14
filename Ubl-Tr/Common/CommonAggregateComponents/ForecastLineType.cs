namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ForecastLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ForecastLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private FrozenDocumentIndicatorType frozenDocumentIndicatorField;

        private ForecastTypeCodeType forecastTypeCodeField;

        private PeriodType forecastPeriodField;

        private SalesItemType salesItemField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FrozenDocumentIndicatorType FrozenDocumentIndicator
        {
            get
            {
                return this.frozenDocumentIndicatorField;
            }
            set
            {
                this.frozenDocumentIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ForecastTypeCodeType ForecastTypeCode
        {
            get
            {
                return this.forecastTypeCodeField;
            }
            set
            {
                this.forecastTypeCodeField = value;
            }
        }

        /// <remarks/>
        public PeriodType ForecastPeriod
        {
            get
            {
                return this.forecastPeriodField;
            }
            set
            {
                this.forecastPeriodField = value;
            }
        }

        /// <remarks/>
        public SalesItemType SalesItem
        {
            get
            {
                return this.salesItemField;
            }
            set
            {
                this.salesItemField = value;
            }
        }
    }
}