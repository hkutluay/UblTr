namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Meter", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class MeterType
    {

        private MeterNumberType meterNumberField;

        private MeterNameType meterNameField;

        private MeterConstantType meterConstantField;

        private MeterConstantCodeType meterConstantCodeField;

        private TotalDeliveredQuantityType totalDeliveredQuantityField;

        private MeterReadingType[] meterReadingField;

        private MeterPropertyType[] meterPropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterNumberType MeterNumber
        {
            get
            {
                return this.meterNumberField;
            }
            set
            {
                this.meterNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterNameType MeterName
        {
            get
            {
                return this.meterNameField;
            }
            set
            {
                this.meterNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterConstantType MeterConstant
        {
            get
            {
                return this.meterConstantField;
            }
            set
            {
                this.meterConstantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterConstantCodeType MeterConstantCode
        {
            get
            {
                return this.meterConstantCodeField;
            }
            set
            {
                this.meterConstantCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalDeliveredQuantityType TotalDeliveredQuantity
        {
            get
            {
                return this.totalDeliveredQuantityField;
            }
            set
            {
                this.totalDeliveredQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterReading")]
        public MeterReadingType[] MeterReading
        {
            get
            {
                return this.meterReadingField;
            }
            set
            {
                this.meterReadingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterProperty")]
        public MeterPropertyType[] MeterProperty
        {
            get
            {
                return this.meterPropertyField;
            }
            set
            {
                this.meterPropertyField = value;
            }
        }
    }
}