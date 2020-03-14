namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ForecastExceptionCriterionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ForecastExceptionCriterionLineType
    {

        private ForecastPurposeCodeType forecastPurposeCodeField;

        private ForecastTypeCodeType forecastTypeCodeField;

        private ComparisonDataSourceCodeType comparisonDataSourceCodeField;

        private DataSourceCodeType dataSourceCodeField;

        private TimeDeltaDaysQuantityType timeDeltaDaysQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ForecastPurposeCodeType ForecastPurposeCode
        {
            get
            {
                return this.forecastPurposeCodeField;
            }
            set
            {
                this.forecastPurposeCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ComparisonDataSourceCodeType ComparisonDataSourceCode
        {
            get
            {
                return this.comparisonDataSourceCodeField;
            }
            set
            {
                this.comparisonDataSourceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DataSourceCodeType DataSourceCode
        {
            get
            {
                return this.dataSourceCodeField;
            }
            set
            {
                this.dataSourceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeDeltaDaysQuantityType TimeDeltaDaysQuantity
        {
            get
            {
                return this.timeDeltaDaysQuantityField;
            }
            set
            {
                this.timeDeltaDaysQuantityField = value;
            }
        }
    }
}