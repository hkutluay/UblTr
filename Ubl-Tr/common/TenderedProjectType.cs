namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AwardedTenderedProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TenderedProjectType
    {

        private VariantIDType variantIDField;

        private FeeAmountType feeAmountField;

        private FeeDescriptionType[] feeDescriptionField;

        private TenderEnvelopeIDType tenderEnvelopeIDField;

        private TenderEnvelopeTypeCodeType tenderEnvelopeTypeCodeField;

        private ProcurementProjectLotType procurementProjectLotField;

        private DocumentReferenceType[] evidenceDocumentReferenceField;

        private TaxTotalType[] taxTotalField;

        private MonetaryTotalType legalMonetaryTotalField;

        private TenderLineType[] tenderLineField;

        private AwardingCriterionResponseType[] awardingCriterionResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VariantIDType VariantID
        {
            get
            {
                return this.variantIDField;
            }
            set
            {
                this.variantIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FeeAmountType FeeAmount
        {
            get
            {
                return this.feeAmountField;
            }
            set
            {
                this.feeAmountField = value;
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
        public ProcurementProjectLotType ProcurementProjectLot
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
        [System.Xml.Serialization.XmlElementAttribute("EvidenceDocumentReference")]
        public DocumentReferenceType[] EvidenceDocumentReference
        {
            get
            {
                return this.evidenceDocumentReferenceField;
            }
            set
            {
                this.evidenceDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return this.taxTotalField;
            }
            set
            {
                this.taxTotalField = value;
            }
        }

        /// <remarks/>
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return this.legalMonetaryTotalField;
            }
            set
            {
                this.legalMonetaryTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TenderLine")]
        public TenderLineType[] TenderLine
        {
            get
            {
                return this.tenderLineField;
            }
            set
            {
                this.tenderLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AwardingCriterionResponse")]
        public AwardingCriterionResponseType[] AwardingCriterionResponse
        {
            get
            {
                return this.awardingCriterionResponseField;
            }
            set
            {
                this.awardingCriterionResponseField = value;
            }
        }
    }
}