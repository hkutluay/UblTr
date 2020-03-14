namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TenderPreparation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TenderPreparationType
    {

        private TenderEnvelopeIDType tenderEnvelopeIDField;

        private TenderEnvelopeTypeCodeType tenderEnvelopeTypeCodeField;

        private DescriptionType[] descriptionField;

        private OpenTenderIDType openTenderIDField;

        private ProcurementProjectLotType[] procurementProjectLotField;

        private TenderRequirementType[] documentTenderRequirementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TenderEnvelopeIDType TenderEnvelopeID
        {
            get
            {
                return this.tenderEnvelopeIDField;
            }
            set
            {
                this.tenderEnvelopeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TenderEnvelopeTypeCodeType TenderEnvelopeTypeCode
        {
            get
            {
                return this.tenderEnvelopeTypeCodeField;
            }
            set
            {
                this.tenderEnvelopeTypeCodeField = value;
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
        public OpenTenderIDType OpenTenderID
        {
            get
            {
                return this.openTenderIDField;
            }
            set
            {
                this.openTenderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLot")]
        public ProcurementProjectLotType[] ProcurementProjectLot
        {
            get
            {
                return this.procurementProjectLotField;
            }
            set
            {
                this.procurementProjectLotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentTenderRequirement")]
        public TenderRequirementType[] DocumentTenderRequirement
        {
            get
            {
                return this.documentTenderRequirementField;
            }
            set
            {
                this.documentTenderRequirementField = value;
            }
        }
    }
}