namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TransportSchedule", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportScheduleType
    {

        private SequenceNumericType sequenceNumericField;

        private ReferenceDateType referenceDateField;

        private ReferenceTimeType referenceTimeField;

        private ReliabilityPercentType reliabilityPercentField;

        private RemarksType[] remarksField;

        private LocationType1 statusLocationField;

        private TransportEventType actualArrivalTransportEventField;

        private TransportEventType actualDepartureTransportEventField;

        private TransportEventType estimatedDepartureTransportEventField;

        private TransportEventType estimatedArrivalTransportEventField;

        private TransportEventType plannedDepartureTransportEventField;

        private TransportEventType plannedArrivalTransportEventField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceNumericType SequenceNumeric
        {
            get
            {
                return this.sequenceNumericField;
            }
            set
            {
                this.sequenceNumericField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        public LocationType1 StatusLocation
        {
            get
            {
                return this.statusLocationField;
            }
            set
            {
                this.statusLocationField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualArrivalTransportEvent
        {
            get
            {
                return this.actualArrivalTransportEventField;
            }
            set
            {
                this.actualArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType ActualDepartureTransportEvent
        {
            get
            {
                return this.actualDepartureTransportEventField;
            }
            set
            {
                this.actualDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType EstimatedDepartureTransportEvent
        {
            get
            {
                return this.estimatedDepartureTransportEventField;
            }
            set
            {
                this.estimatedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType EstimatedArrivalTransportEvent
        {
            get
            {
                return this.estimatedArrivalTransportEventField;
            }
            set
            {
                this.estimatedArrivalTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedDepartureTransportEvent
        {
            get
            {
                return this.plannedDepartureTransportEventField;
            }
            set
            {
                this.plannedDepartureTransportEventField = value;
            }
        }

        /// <remarks/>
        public TransportEventType PlannedArrivalTransportEvent
        {
            get
            {
                return this.plannedArrivalTransportEventField;
            }
            set
            {
                this.plannedArrivalTransportEventField = value;
            }
        }
    }
}