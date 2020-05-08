namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("UnsignedDataObjectProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class UnsignedDataObjectPropertiesType
    {

        private AnyType[] unsignedDataObjectPropertyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UnsignedDataObjectProperty")]
        public AnyType[] UnsignedDataObjectProperty
        {
            get
            {
                return this.unsignedDataObjectPropertyField;
            }
            set
            {
                this.unsignedDataObjectPropertyField = value;
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