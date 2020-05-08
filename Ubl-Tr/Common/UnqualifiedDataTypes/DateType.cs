namespace UblTr.Common
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValidityStartDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValidationDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxPointDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubmissionDueDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubmissionDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StartDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SourceForecastIssueDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RevisionDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResponseDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResolutionDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequiredDeliveryDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestedPublicationDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestedDespatchDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestedDeliveryDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegistrationExpirationDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegistrationDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegisteredDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReferenceDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReceivedDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PreviousMeterReadingDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlannedDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentDueDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaidDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OccurrenceDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NominationDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManufactureDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LatestSecurityClearanceDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LatestProposalAcceptanceDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LatestPickupDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LatestMeterReadingDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LatestDeliveryDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LastRevisionDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IssueDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InstallmentDueDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GuaranteedDespatchDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FirstShipmentAvailibilityDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpiryDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EstimatedDespatchDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EstimatedDeliveryDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EndDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EffectiveDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EarliestPickupDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DueDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparisonForecastIssueDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CallDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BirthDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BestBeforeDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AwardDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AvailabilityDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApprovalDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActualPickupDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActualDespatchDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActualDeliveryDateType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class DateType
    {

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}