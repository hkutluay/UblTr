namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class SignatureType
    {

        private IDType idField;

        private PartyType signatoryPartyField;

        private AttachmentType digitalSignatureAttachmentField;

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
        public PartyType SignatoryParty
        {
            get
            {
                return this.signatoryPartyField;
            }
            set
            {
                this.signatoryPartyField = value;
            }
        }

        /// <remarks/>
        public AttachmentType DigitalSignatureAttachment
        {
            get
            {
                return this.digitalSignatureAttachmentField;
            }
            set
            {
                this.digitalSignatureAttachmentField = value;
            }
        }
    }
}