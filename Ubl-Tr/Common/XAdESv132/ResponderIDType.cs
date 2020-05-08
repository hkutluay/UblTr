namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class ResponderIDType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ByKey", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("ByName", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}