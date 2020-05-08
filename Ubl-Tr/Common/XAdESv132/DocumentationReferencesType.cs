namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class DocumentationReferencesType
    {

        private string[] documentationReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentationReference", DataType = "anyURI")]
        public string[] DocumentationReference
        {
            get
            {
                return this.documentationReferenceField;
            }
            set
            {
                this.documentationReferenceField = value;
            }
        }
    }
}