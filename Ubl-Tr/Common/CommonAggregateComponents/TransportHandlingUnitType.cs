namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PackagedTransportHandlingUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportHandlingUnitType
    {

        private IDType idField;

        private TransportHandlingUnitTypeCodeType transportHandlingUnitTypeCodeField;

        private HandlingCodeType handlingCodeField;

        private HandlingInstructionsType handlingInstructionsField;

        private HazardousRiskIndicatorType hazardousRiskIndicatorField;

        private TotalGoodsItemQuantityType totalGoodsItemQuantityField;

        private TotalPackageQuantityType totalPackageQuantityField;

        private DamageRemarksType[] damageRemarksField;

        private TraceIDType traceIDField;

        private PackageType[] actualPackageField;

        private TransportEquipmentType[] transportEquipmentField;

        private TransportMeansType[] transportMeansField;

        private HazardousGoodsTransitType[] hazardousGoodsTransitField;

        private DimensionType[] measurementDimensionField;

        private TemperatureType minimumTemperatureField;

        private TemperatureType maximumTemperatureField;

        private DimensionType floorSpaceMeasurementDimensionField;

        private DimensionType palletSpaceMeasurementDimensionField;

        private DocumentReferenceType[] shipmentDocumentReferenceField;

        private CustomsDeclarationType[] customsDeclarationField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportHandlingUnitTypeCodeType TransportHandlingUnitTypeCode
        {
            get
            {
                return this.transportHandlingUnitTypeCodeField;
            }
            set
            {
                this.transportHandlingUnitTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingCodeType HandlingCode
        {
            get
            {
                return this.handlingCodeField;
            }
            set
            {
                this.handlingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingInstructionsType HandlingInstructions
        {
            get
            {
                return this.handlingInstructionsField;
            }
            set
            {
                this.handlingInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return this.hazardousRiskIndicatorField;
            }
            set
            {
                this.hazardousRiskIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity
        {
            get
            {
                return this.totalGoodsItemQuantityField;
            }
            set
            {
                this.totalGoodsItemQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalPackageQuantityType TotalPackageQuantity
        {
            get
            {
                return this.totalPackageQuantityField;
            }
            set
            {
                this.totalPackageQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DamageRemarksType[] DamageRemarks
        {
            get
            {
                return this.damageRemarksField;
            }
            set
            {
                this.damageRemarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TraceIDType TraceID
        {
            get
            {
                return this.traceIDField;
            }
            set
            {
                this.traceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualPackage")]
        public PackageType[] ActualPackage
        {
            get
            {
                return this.actualPackageField;
            }
            set
            {
                this.actualPackageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipment")]
        public TransportEquipmentType[] TransportEquipment
        {
            get
            {
                return this.transportEquipmentField;
            }
            set
            {
                this.transportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportMeans")]
        public TransportMeansType[] TransportMeans
        {
            get
            {
                return this.transportMeansField;
            }
            set
            {
                this.transportMeansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit
        {
            get
            {
                return this.hazardousGoodsTransitField;
            }
            set
            {
                this.hazardousGoodsTransitField = value;
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

        /// <remarks/>
        public TemperatureType MinimumTemperature
        {
            get
            {
                return this.minimumTemperatureField;
            }
            set
            {
                this.minimumTemperatureField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MaximumTemperature
        {
            get
            {
                return this.maximumTemperatureField;
            }
            set
            {
                this.maximumTemperatureField = value;
            }
        }

        /// <remarks/>
        public DimensionType FloorSpaceMeasurementDimension
        {
            get
            {
                return this.floorSpaceMeasurementDimensionField;
            }
            set
            {
                this.floorSpaceMeasurementDimensionField = value;
            }
        }

        /// <remarks/>
        public DimensionType PalletSpaceMeasurementDimension
        {
            get
            {
                return this.palletSpaceMeasurementDimensionField;
            }
            set
            {
                this.palletSpaceMeasurementDimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference")]
        public DocumentReferenceType[] ShipmentDocumentReference
        {
            get
            {
                return this.shipmentDocumentReferenceField;
            }
            set
            {
                this.shipmentDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration")]
        public CustomsDeclarationType[] CustomsDeclaration
        {
            get
            {
                return this.customsDeclarationField;
            }
            set
            {
                this.customsDeclarationField = value;
            }
        }
    }
}