namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SigningCertificate", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class CertIDListType
    {

        private CertIDType[] certField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cert")]
        public CertIDType[] Cert
        {
            get
            {
                return this.certField;
            }
            set
            {
                this.certField = value;
            }
        }
    }
}