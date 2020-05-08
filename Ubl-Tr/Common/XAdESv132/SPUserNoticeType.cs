namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SPUserNotice", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class SPUserNoticeType
    {

        private NoticeReferenceType noticeRefField;

        private string explicitTextField;

        /// <remarks/>
        public NoticeReferenceType NoticeRef
        {
            get
            {
                return this.noticeRefField;
            }
            set
            {
                this.noticeRefField = value;
            }
        }

        /// <remarks/>
        public string ExplicitText
        {
            get
            {
                return this.explicitTextField;
            }
            set
            {
                this.explicitTextField = value;
            }
        }
    }
}