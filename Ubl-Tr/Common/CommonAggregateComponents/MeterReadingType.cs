namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("MeterReading", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class MeterReadingType
    {

        private IDType idField;

        private MeterReadingTypeType meterReadingType1Field;

        private MeterReadingTypeCodeType meterReadingTypeCodeField;

        private PreviousMeterReadingDateType previousMeterReadingDateField;

        private PreviousMeterQuantityType previousMeterQuantityField;

        private LatestMeterReadingDateType latestMeterReadingDateField;

        private LatestMeterQuantityType latestMeterQuantityField;

        private PreviousMeterReadingMethodType previousMeterReadingMethodField;

        private PreviousMeterReadingMethodCodeType previousMeterReadingMethodCodeField;

        private LatestMeterReadingMethodType latestMeterReadingMethodField;

        private LatestMeterReadingMethodCodeType latestMeterReadingMethodCodeField;

        private MeterReadingCommentsType[] meterReadingCommentsField;

        private DeliveredQuantityType deliveredQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterReadingType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterReadingTypeType MeterReadingType1
        {
            get
            {
                return this.meterReadingType1Field;
            }
            set
            {
                this.meterReadingType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterReadingTypeCodeType MeterReadingTypeCode
        {
            get
            {
                return this.meterReadingTypeCodeField;
            }
            set
            {
                this.meterReadingTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterReadingDateType PreviousMeterReadingDate
        {
            get
            {
                return this.previousMeterReadingDateField;
            }
            set
            {
                this.previousMeterReadingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterQuantityType PreviousMeterQuantity
        {
            get
            {
                return this.previousMeterQuantityField;
            }
            set
            {
                this.previousMeterQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterReadingDateType LatestMeterReadingDate
        {
            get
            {
                return this.latestMeterReadingDateField;
            }
            set
            {
                this.latestMeterReadingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterQuantityType LatestMeterQuantity
        {
            get
            {
                return this.latestMeterQuantityField;
            }
            set
            {
                this.latestMeterQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterReadingMethodType PreviousMeterReadingMethod
        {
            get
            {
                return this.previousMeterReadingMethodField;
            }
            set
            {
                this.previousMeterReadingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreviousMeterReadingMethodCodeType PreviousMeterReadingMethodCode
        {
            get
            {
                return this.previousMeterReadingMethodCodeField;
            }
            set
            {
                this.previousMeterReadingMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterReadingMethodType LatestMeterReadingMethod
        {
            get
            {
                return this.latestMeterReadingMethodField;
            }
            set
            {
                this.latestMeterReadingMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestMeterReadingMethodCodeType LatestMeterReadingMethodCode
        {
            get
            {
                return this.latestMeterReadingMethodCodeField;
            }
            set
            {
                this.latestMeterReadingMethodCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterReadingComments", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterReadingCommentsType[] MeterReadingComments
        {
            get
            {
                return this.meterReadingCommentsField;
            }
            set
            {
                this.meterReadingCommentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeliveredQuantityType DeliveredQuantity
        {
            get
            {
                return this.deliveredQuantityField;
            }
            set
            {
                this.deliveredQuantityField = value;
            }
        }
    }
}