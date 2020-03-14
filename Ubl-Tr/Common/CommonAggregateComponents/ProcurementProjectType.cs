namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ProcurementProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ProcurementProjectType
    {

        private IDType idField;

        private NameType1[] nameField;

        private DescriptionType[] descriptionField;

        private ProcurementTypeCodeType procurementTypeCodeField;

        private ProcurementSubTypeCodeType procurementSubTypeCodeField;

        private QualityControlCodeType qualityControlCodeField;

        private RequiredFeeAmountType requiredFeeAmountField;

        private FeeDescriptionType[] feeDescriptionField;

        private RequestedDeliveryDateType requestedDeliveryDateField;

        private EstimatedOverallContractQuantityType estimatedOverallContractQuantityField;

        private NoteType[] noteField;

        private RequestedTenderTotalType requestedTenderTotalField;

        private CommodityClassificationType mainCommodityClassificationField;

        private CommodityClassificationType[] additionalCommodityClassificationField;

        private LocationType1[] realizedLocationField;

        private PeriodType plannedPeriodField;

        private ContractExtensionType contractExtensionField;

        private RequestForTenderLineType[] requestForTenderLineField;

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
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1[] Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
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
        public ProcurementTypeCodeType ProcurementTypeCode
        {
            get
            {
                return this.procurementTypeCodeField;
            }
            set
            {
                this.procurementTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProcurementSubTypeCodeType ProcurementSubTypeCode
        {
            get
            {
                return this.procurementSubTypeCodeField;
            }
            set
            {
                this.procurementSubTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QualityControlCodeType QualityControlCode
        {
            get
            {
                return this.qualityControlCodeField;
            }
            set
            {
                this.qualityControlCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredFeeAmountType RequiredFeeAmount
        {
            get
            {
                return this.requiredFeeAmountField;
            }
            set
            {
                this.requiredFeeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FeeDescriptionType[] FeeDescription
        {
            get
            {
                return this.feeDescriptionField;
            }
            set
            {
                this.feeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequestedDeliveryDateType RequestedDeliveryDate
        {
            get
            {
                return this.requestedDeliveryDateField;
            }
            set
            {
                this.requestedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedOverallContractQuantityType EstimatedOverallContractQuantity
        {
            get
            {
                return this.estimatedOverallContractQuantityField;
            }
            set
            {
                this.estimatedOverallContractQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }

        /// <remarks/>
        public RequestedTenderTotalType RequestedTenderTotal
        {
            get
            {
                return this.requestedTenderTotalField;
            }
            set
            {
                this.requestedTenderTotalField = value;
            }
        }

        /// <remarks/>
        public CommodityClassificationType MainCommodityClassification
        {
            get
            {
                return this.mainCommodityClassificationField;
            }
            set
            {
                this.mainCommodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalCommodityClassification")]
        public CommodityClassificationType[] AdditionalCommodityClassification
        {
            get
            {
                return this.additionalCommodityClassificationField;
            }
            set
            {
                this.additionalCommodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RealizedLocation")]
        public LocationType1[] RealizedLocation
        {
            get
            {
                return this.realizedLocationField;
            }
            set
            {
                this.realizedLocationField = value;
            }
        }

        /// <remarks/>
        public PeriodType PlannedPeriod
        {
            get
            {
                return this.plannedPeriodField;
            }
            set
            {
                this.plannedPeriodField = value;
            }
        }

        /// <remarks/>
        public ContractExtensionType ContractExtension
        {
            get
            {
                return this.contractExtensionField;
            }
            set
            {
                this.contractExtensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestForTenderLine")]
        public RequestForTenderLineType[] RequestForTenderLine
        {
            get
            {
                return this.requestForTenderLineField;
            }
            set
            {
                this.requestForTenderLineField = value;
            }
        }
    }
}