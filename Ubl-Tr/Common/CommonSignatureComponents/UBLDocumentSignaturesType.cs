namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("UBLDocumentSignatures", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2", IsNullable = false)]
    public partial class UBLDocumentSignaturesType
    {

        private SignatureInformationType[] signatureInformationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignatureInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
        public SignatureInformationType[] SignatureInformation
        {
            get
            {
                return this.signatureInformationField;
            }
            set
            {
                this.signatureInformationField = value;
            }
        }
    }
}