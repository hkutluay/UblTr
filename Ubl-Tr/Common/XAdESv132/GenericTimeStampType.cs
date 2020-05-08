namespace UblTr.Common
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherTimeStampType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XAdESTimeStampType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public abstract partial class GenericTimeStampType
    {

        private object[] itemsField;

        private CanonicalizationMethodType1 canonicalizationMethodField;

        private object[] items1Field;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Include", typeof(IncludeType))]
        [System.Xml.Serialization.XmlElementAttribute("ReferenceInfo", typeof(ReferenceInfoType))]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public CanonicalizationMethodType1 CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedPKIDataType))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(AnyType))]
        public object[] Items1
        {
            get
            {
                return this.items1Field;
            }
            set
            {
                this.items1Field = value;
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