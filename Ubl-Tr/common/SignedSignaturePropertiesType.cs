namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class SignedSignaturePropertiesType
    {

        private System.DateTime signingTimeField;

        private bool signingTimeFieldSpecified;

        private CertIDType[] signingCertificateField;

        private SignaturePolicyIdentifierType signaturePolicyIdentifierField;

        private SignatureProductionPlaceType signatureProductionPlaceField;

        private SignerRoleType signerRoleField;

        private string idField;

        /// <remarks/>
        public System.DateTime SigningTime
        {
            get
            {
                return this.signingTimeField;
            }
            set
            {
                this.signingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SigningTimeSpecified
        {
            get
            {
                return this.signingTimeFieldSpecified;
            }
            set
            {
                this.signingTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable = false)]
        public CertIDType[] SigningCertificate
        {
            get
            {
                return this.signingCertificateField;
            }
            set
            {
                this.signingCertificateField = value;
            }
        }

        /// <remarks/>
        public SignaturePolicyIdentifierType SignaturePolicyIdentifier
        {
            get
            {
                return this.signaturePolicyIdentifierField;
            }
            set
            {
                this.signaturePolicyIdentifierField = value;
            }
        }

        /// <remarks/>
        public SignatureProductionPlaceType SignatureProductionPlace
        {
            get
            {
                return this.signatureProductionPlaceField;
            }
            set
            {
                this.signatureProductionPlaceField = value;
            }
        }

        /// <remarks/>
        public SignerRoleType SignerRole
        {
            get
            {
                return this.signerRoleField;
            }
            set
            {
                this.signerRoleField = value;
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
    }
}