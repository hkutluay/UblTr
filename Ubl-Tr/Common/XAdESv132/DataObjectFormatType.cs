namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("DataObjectFormat", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class DataObjectFormatType
    {

        private string descriptionField;

        private ObjectIdentifierType objectIdentifierField;

        private string mimeTypeField;

        private string encodingField;

        private string objectReferenceField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public ObjectIdentifierType ObjectIdentifier
        {
            get
            {
                return this.objectIdentifierField;
            }
            set
            {
                this.objectIdentifierField = value;
            }
        }

        /// <remarks/>
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string ObjectReference
        {
            get
            {
                return this.objectReferenceField;
            }
            set
            {
                this.objectReferenceField = value;
            }
        }
    }
}