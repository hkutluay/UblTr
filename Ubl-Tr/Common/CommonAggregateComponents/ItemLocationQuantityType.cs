namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ItemLocationQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemLocationQuantityType
    {

        private LeadTimeMeasureType leadTimeMeasureField;

        private MinimumQuantityType minimumQuantityField;

        private MaximumQuantityType maximumQuantityField;

        private HazardousRiskIndicatorType hazardousRiskIndicatorField;

        private TradingRestrictionsType[] tradingRestrictionsField;

        private AddressType[] applicableTerritoryAddressField;

        private PriceType priceField;

        private DeliveryUnitType[] deliveryUnitField;

        private TaxCategoryType[] applicableTaxCategoryField;

        private PackageType packageField;

        private AllowanceChargeType[] allowanceChargeField;

        private DependentPriceReferenceType dependentPriceReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LeadTimeMeasureType LeadTimeMeasure
        {
            get
            {
                return this.leadTimeMeasureField;
            }
            set
            {
                this.leadTimeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return this.minimumQuantityField;
            }
            set
            {
                this.minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return this.maximumQuantityField;
            }
            set
            {
                this.maximumQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("TradingRestrictions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TradingRestrictionsType[] TradingRestrictions
        {
            get
            {
                return this.tradingRestrictionsField;
            }
            set
            {
                this.tradingRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTerritoryAddress")]
        public AddressType[] ApplicableTerritoryAddress
        {
            get
            {
                return this.applicableTerritoryAddressField;
            }
            set
            {
                this.applicableTerritoryAddressField = value;
            }
        }

        /// <remarks/>
        public PriceType Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit")]
        public DeliveryUnitType[] DeliveryUnit
        {
            get
            {
                return this.deliveryUnitField;
            }
            set
            {
                this.deliveryUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory")]
        public TaxCategoryType[] ApplicableTaxCategory
        {
            get
            {
                return this.applicableTaxCategoryField;
            }
            set
            {
                this.applicableTaxCategoryField = value;
            }
        }

        /// <remarks/>
        public PackageType Package
        {
            get
            {
                return this.packageField;
            }
            set
            {
                this.packageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
            }
        }

        /// <remarks/>
        public DependentPriceReferenceType DependentPriceReference
        {
            get
            {
                return this.dependentPriceReferenceField;
            }
            set
            {
                this.dependentPriceReferenceField = value;
            }
        }
    }
}