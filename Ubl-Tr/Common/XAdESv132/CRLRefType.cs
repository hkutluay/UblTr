namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CRLRefType
    {

        private DigestAlgAndValueType digestAlgAndValueField;

        private CRLIdentifierType cRLIdentifierField;

        /// <remarks/>
        public DigestAlgAndValueType DigestAlgAndValue
        {
            get
            {
                return this.digestAlgAndValueField;
            }
            set
            {
                this.digestAlgAndValueField = value;
            }
        }

        /// <remarks/>
        public CRLIdentifierType CRLIdentifier
        {
            get
            {
                return this.cRLIdentifierField;
            }
            set
            {
                this.cRLIdentifierField = value;
            }
        }
    }
}