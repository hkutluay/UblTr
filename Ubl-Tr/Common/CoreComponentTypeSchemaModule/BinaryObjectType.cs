using System;
using System.Xml.Serialization;

namespace UblTr.Common
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SoundType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PictureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphicType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryObjectType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EmbeddedDocumentBinaryObjectType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class BinaryObjectType
    {

        private string formatField;

        private string mimeCodeField;

        private string encodingCodeField;

        private string characterSetCodeField;

        private string uriField;

        private string filenameField;

        private byte[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string mimeCode
        {
            get
            {
                return this.mimeCodeField;
            }
            set
            {
                this.mimeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string encodingCode
        {
            get
            {
                return this.encodingCodeField;
            }
            set
            {
                this.encodingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string characterSetCode
        {
            get
            {
                return this.characterSetCodeField;
            }
            set
            {
                this.characterSetCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string ValueBase64
        {
            get
            {
                return System.Convert.ToBase64String(this.valueField);
            }
            set
            {
                try
                {
                    this.valueField = System.Convert.FromBase64String(value);
                }
                catch (Exception)
                {
                    this.valueField = null;
                }
            }
        }
    }
}