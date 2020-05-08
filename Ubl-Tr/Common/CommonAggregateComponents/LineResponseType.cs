namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("LineResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class LineResponseType
    {

        private LineReferenceType lineReferenceField;

        private ResponseType[] responseField;

        /// <remarks/>
        public LineReferenceType LineReference
        {
            get
            {
                return this.lineReferenceField;
            }
            set
            {
                this.lineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Response")]
        public ResponseType[] Response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
            }
        }
    }
}