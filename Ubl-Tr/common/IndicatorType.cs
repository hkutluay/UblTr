namespace UblTr.Common
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VariantConstraintIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnknownPriceIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToOrderIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThirdPartyPayerIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxIncludedIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TaxEvidenceIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatusAvailableIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SplitConsignmentIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpecialSecurityIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SoleProprietorshipIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnableMaterialIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReturnabilityIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequiredCurriculaIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RefrigerationOnIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RefrigeratedIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PublishAwardIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrizeIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PricingUpdateRequestIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrepaidIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PreCarriageIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartialDeliveryIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherConditionsIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderableIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OptionalLineItemIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OnCarriageIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarkCareIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarkAttentionIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LivestockIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LegalStatusIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemUpdateRequestIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IndicationIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HumanFoodIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HumanFoodApprovedIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HazardousRiskIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GovernmentAgreementConstraintIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeneralCargoIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FullyPaidSharesIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FrozenDocumentIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FreeOfChargeIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FollowupContractIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DangerousGoodsApprovedIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomsImportClassifiedIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CopyIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContainerizedIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsolidatableIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompletionIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CatalogueIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CandidateReductionConstraintIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkCargoIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BindingOnBuyerIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BasedOnConsensusIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BalanceBroughtForwardIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BackOrderAllowedIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuctionConstraintIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnimalFoodIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AnimalFoodApprovedIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdValoremIndicatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AcceptedIndicatorType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class IndicatorType
    {

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
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