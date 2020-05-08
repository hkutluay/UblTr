namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.4.1#")]
    [System.Xml.Serialization.XmlRootAttribute("TimeStampValidationData", Namespace = "http://uri.etsi.org/01903/v1.4.1#", IsNullable = false)]
    public partial class ValidationDataType
    {

        private CertificateValuesType certificateValuesField;

        private RevocationValuesType revocationValuesField;

        private string idField;

        private string uRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public CertificateValuesType CertificateValues
        {
            get
            {
                return this.certificateValuesField;
            }
            set
            {
                this.certificateValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public RevocationValuesType RevocationValues
        {
            get
            {
                return this.revocationValuesField;
            }
            set
            {
                this.revocationValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }
}