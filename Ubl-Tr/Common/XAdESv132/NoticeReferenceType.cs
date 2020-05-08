namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class NoticeReferenceType
    {

        private string organizationField;

        private string[] noticeNumbersField;

        /// <remarks/>
        public string Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("int", DataType = "integer", IsNullable = false)]
        public string[] NoticeNumbers
        {
            get
            {
                return this.noticeNumbersField;
            }
            set
            {
                this.noticeNumbersField = value;
            }
        }
    }
}