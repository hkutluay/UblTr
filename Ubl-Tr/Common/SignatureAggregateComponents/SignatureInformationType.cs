namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2", IsNullable = false)]
    public partial class SignatureInformationType
    {

        private IDType idField;

        private ReferencedSignatureIDType referencedSignatureIDField;

        private SignatureType1 signatureField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2")]
        public ReferencedSignatureIDType ReferencedSignatureID
        {
            get
            {
                return this.referencedSignatureIDField;
            }
            set
            {
                this.referencedSignatureIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType1 Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }
}