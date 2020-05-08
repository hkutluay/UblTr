namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TransportationSegment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportationSegmentType
    {

        private SequenceNumericType sequenceNumericField;

        private TransportExecutionPlanReferenceIDType transportExecutionPlanReferenceIDField;

        private TransportationServiceType transportationServiceField;

        private PartyType transportServiceProviderPartyField;

        private ConsignmentType referencedConsignmentField;

        private ShipmentStageType[] shipmentStageField;

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
        public TransportExecutionPlanReferenceIDType TransportExecutionPlanReferenceID
        {
            get
            {
                return this.transportExecutionPlanReferenceIDField;
            }
            set
            {
                this.transportExecutionPlanReferenceIDField = value;
            }
        }

        /// <remarks/>
        public TransportationServiceType TransportationService
        {
            get
            {
                return this.transportationServiceField;
            }
            set
            {
                this.transportationServiceField = value;
            }
        }

        /// <remarks/>
        public PartyType TransportServiceProviderParty
        {
            get
            {
                return this.transportServiceProviderPartyField;
            }
            set
            {
                this.transportServiceProviderPartyField = value;
            }
        }

        /// <remarks/>
        public ConsignmentType ReferencedConsignment
        {
            get
            {
                return this.referencedConsignmentField;
            }
            set
            {
                this.referencedConsignmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
        public ShipmentStageType[] ShipmentStage
        {
            get
            {
                return this.shipmentStageField;
            }
            set
            {
                this.shipmentStageField = value;
            }
        }
    }
}