namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
    public partial class UBLExtensionsType
    {

        private UBLExtensionType[] uBLExtensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UBLExtension")]
        public UBLExtensionType[] UBLExtension
        {
            get
            {
                return this.uBLExtensionField;
            }
            set
            {
                this.uBLExtensionField = value;
            }
        }
    }
}