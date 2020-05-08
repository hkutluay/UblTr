namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("CommitmentTypeIndication", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class CommitmentTypeIndicationType
    {

        private ObjectIdentifierType commitmentTypeIdField;

        private object[] itemsField;

        private AnyType[] commitmentTypeQualifiersField;

        /// <remarks/>
        public ObjectIdentifierType CommitmentTypeId
        {
            get
            {
                return this.commitmentTypeIdField;
            }
            set
            {
                this.commitmentTypeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllSignedDataObjects", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ObjectReference", typeof(string), DataType = "anyURI")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CommitmentTypeQualifier", IsNullable = false)]
        public AnyType[] CommitmentTypeQualifiers
        {
            get
            {
                return this.commitmentTypeQualifiersField;
            }
            set
            {
                this.commitmentTypeQualifiersField = value;
            }
        }
    }
}