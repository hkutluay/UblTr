namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class OrderReferenceType
    {

        private IDType idField;

        private SalesOrderIDType salesOrderIDField;

        private IssueDateType issueDateField;

        private OrderTypeCodeType orderTypeCodeField;

        private DocumentReferenceType documentReferenceField;

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
        public SalesOrderIDType SalesOrderID
        {
            get
            {
                return this.salesOrderIDField;
            }
            set
            {
                this.salesOrderIDField = value;
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
        public OrderTypeCodeType OrderTypeCode
        {
            get
            {
                return this.orderTypeCodeField;
            }
            set
            {
                this.orderTypeCodeField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }
    }
}