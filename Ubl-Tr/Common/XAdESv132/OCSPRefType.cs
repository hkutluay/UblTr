namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OCSPRefType
    {

        private OCSPIdentifierType oCSPIdentifierField;

        private DigestAlgAndValueType digestAlgAndValueField;

        /// <remarks/>
        public OCSPIdentifierType OCSPIdentifier
        {
            get
            {
                return this.oCSPIdentifierField;
            }
            set
            {
                this.oCSPIdentifierField = value;
            }
        }

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
    }
}