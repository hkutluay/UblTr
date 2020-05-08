namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CurrentStatus", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class StatusType
    {

        private ConditionCodeType conditionCodeField;

        private ReferenceDateType referenceDateField;

        private ReferenceTimeType referenceTimeField;

        private DescriptionType[] descriptionField;

        private StatusReasonCodeType statusReasonCodeField;

        private StatusReasonType[] statusReasonField;

        private SequenceIDType sequenceIDField;

        private TextType2[] textField;

        private IndicationIndicatorType indicationIndicatorField;

        private PercentType1 percentField;

        private ReliabilityPercentType reliabilityPercentField;

        private ConditionType1[] conditionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConditionCodeType ConditionCode
        {
            get
            {
                return this.conditionCodeField;
            }
            set
            {
                this.conditionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceDateType ReferenceDate
        {
            get
            {
                return this.referenceDateField;
            }
            set
            {
                this.referenceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceTimeType ReferenceTime
        {
            get
            {
                return this.referenceTimeField;
            }
            set
            {
                this.referenceTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StatusReasonCodeType StatusReasonCode
        {
            get
            {
                return this.statusReasonCodeField;
            }
            set
            {
                this.statusReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StatusReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StatusReasonType[] StatusReason
        {
            get
            {
                return this.statusReasonField;
            }
            set
            {
                this.statusReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceIDType SequenceID
        {
            get
            {
                return this.sequenceIDField;
            }
            set
            {
                this.sequenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType2[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicationIndicatorType IndicationIndicator
        {
            get
            {
                return this.indicationIndicatorField;
            }
            set
            {
                this.indicationIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType1 Percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReliabilityPercentType ReliabilityPercent
        {
            get
            {
                return this.reliabilityPercentField;
            }
            set
            {
                this.reliabilityPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Condition")]
        public ConditionType1[] Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }
    }
}