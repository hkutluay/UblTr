namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ApplicableTransportMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportMeansType
    {

        private JourneyIDType journeyIDField;

        private RegistrationNationalityIDType registrationNationalityIDField;

        private RegistrationNationalityType[] registrationNationalityField;

        private DirectionCodeType directionCodeField;

        private TransportMeansTypeCodeType transportMeansTypeCodeField;

        private TradeServiceCodeType tradeServiceCodeField;

        private StowageType stowageField;

        private AirTransportType airTransportField;

        private RoadTransportType roadTransportField;

        private RailTransportType railTransportField;

        private MaritimeTransportType maritimeTransportField;

        private PartyType ownerPartyField;

        private DimensionType[] measurementDimensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public JourneyIDType JourneyID
        {
            get
            {
                return this.journeyIDField;
            }
            set
            {
                this.journeyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNationalityIDType RegistrationNationalityID
        {
            get
            {
                return this.registrationNationalityIDField;
            }
            set
            {
                this.registrationNationalityIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegistrationNationality", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNationalityType[] RegistrationNationality
        {
            get
            {
                return this.registrationNationalityField;
            }
            set
            {
                this.registrationNationalityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DirectionCodeType DirectionCode
        {
            get
            {
                return this.directionCodeField;
            }
            set
            {
                this.directionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportMeansTypeCodeType TransportMeansTypeCode
        {
            get
            {
                return this.transportMeansTypeCodeField;
            }
            set
            {
                this.transportMeansTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TradeServiceCodeType TradeServiceCode
        {
            get
            {
                return this.tradeServiceCodeField;
            }
            set
            {
                this.tradeServiceCodeField = value;
            }
        }

        /// <remarks/>
        public StowageType Stowage
        {
            get
            {
                return this.stowageField;
            }
            set
            {
                this.stowageField = value;
            }
        }

        /// <remarks/>
        public AirTransportType AirTransport
        {
            get
            {
                return this.airTransportField;
            }
            set
            {
                this.airTransportField = value;
            }
        }

        /// <remarks/>
        public RoadTransportType RoadTransport
        {
            get
            {
                return this.roadTransportField;
            }
            set
            {
                this.roadTransportField = value;
            }
        }

        /// <remarks/>
        public RailTransportType RailTransport
        {
            get
            {
                return this.railTransportField;
            }
            set
            {
                this.railTransportField = value;
            }
        }

        /// <remarks/>
        public MaritimeTransportType MaritimeTransport
        {
            get
            {
                return this.maritimeTransportField;
            }
            set
            {
                this.maritimeTransportField = value;
            }
        }

        /// <remarks/>
        public PartyType OwnerParty
        {
            get
            {
                return this.ownerPartyField;
            }
            set
            {
                this.ownerPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return this.measurementDimensionField;
            }
            set
            {
                this.measurementDimensionField = value;
            }
        }
    }
}