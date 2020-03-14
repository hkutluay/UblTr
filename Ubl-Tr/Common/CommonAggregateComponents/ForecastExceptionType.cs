namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ForecastException", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ForecastExceptionType
    {

        private ForecastPurposeCodeType forecastPurposeCodeField;

        private ForecastTypeCodeType forecastTypeCodeField;

        private IssueDateType issueDateField;

        private IssueTimeType issueTimeField;

        private DataSourceCodeType dataSourceCodeField;

        private ComparisonDataCodeType comparisonDataCodeField;

        private ComparisonForecastIssueTimeType comparisonForecastIssueTimeField;

        private ComparisonForecastIssueDateType comparisonForecastIssueDateField;

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
        public IssueDateType IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTimeType IssueTime
        {
            get
            {
                return this.issueTimeField;
            }
            set
            {
                this.issueTimeField = value;
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
        public ComparisonDataCodeType ComparisonDataCode
        {
            get
            {
                return this.comparisonDataCodeField;
            }
            set
            {
                this.comparisonDataCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ComparisonForecastIssueTimeType ComparisonForecastIssueTime
        {
            get
            {
                return this.comparisonForecastIssueTimeField;
            }
            set
            {
                this.comparisonForecastIssueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ComparisonForecastIssueDateType ComparisonForecastIssueDate
        {
            get
            {
                return this.comparisonForecastIssueDateField;
            }
            set
            {
                this.comparisonForecastIssueDateField = value;
            }
        }
    }
}