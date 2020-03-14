namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TendererPartyQualification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TendererPartyQualificationType
    {

        private ProcurementProjectLotType[] interestedProcurementProjectLotField;

        private QualifyingPartyType mainQualifyingPartyField;

        private QualifyingPartyType[] additionalQualifyingPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterestedProcurementProjectLot")]
        public ProcurementProjectLotType[] InterestedProcurementProjectLot
        {
            get
            {
                return this.interestedProcurementProjectLotField;
            }
            set
            {
                this.interestedProcurementProjectLotField = value;
            }
        }

        /// <remarks/>
        public QualifyingPartyType MainQualifyingParty
        {
            get
            {
                return this.mainQualifyingPartyField;
            }
            set
            {
                this.mainQualifyingPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalQualifyingParty")]
        public QualifyingPartyType[] AdditionalQualifyingParty
        {
            get
            {
                return this.additionalQualifyingPartyField;
            }
            set
            {
                this.additionalQualifyingPartyField = value;
            }
        }
    }
}