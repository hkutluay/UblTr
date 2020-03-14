namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ItemManagementProfile", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemManagementProfileType
    {

        private FrozenPeriodDaysNumericType frozenPeriodDaysNumericField;

        private MinimumInventoryQuantityType minimumInventoryQuantityField;

        private MultipleOrderQuantityType multipleOrderQuantityField;

        private OrderIntervalDaysNumericType orderIntervalDaysNumericField;

        private ReplenishmentOwnerDescriptionType[] replenishmentOwnerDescriptionField;

        private TargetServicePercentType targetServicePercentField;

        private TargetInventoryQuantityType targetInventoryQuantityField;

        private PeriodType effectivePeriodField;

        private ItemType itemField;

        private ItemLocationQuantityType itemLocationQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FrozenPeriodDaysNumericType FrozenPeriodDaysNumeric
        {
            get
            {
                return this.frozenPeriodDaysNumericField;
            }
            set
            {
                this.frozenPeriodDaysNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumInventoryQuantityType MinimumInventoryQuantity
        {
            get
            {
                return this.minimumInventoryQuantityField;
            }
            set
            {
                this.minimumInventoryQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MultipleOrderQuantityType MultipleOrderQuantity
        {
            get
            {
                return this.multipleOrderQuantityField;
            }
            set
            {
                this.multipleOrderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderIntervalDaysNumericType OrderIntervalDaysNumeric
        {
            get
            {
                return this.orderIntervalDaysNumericField;
            }
            set
            {
                this.orderIntervalDaysNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReplenishmentOwnerDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReplenishmentOwnerDescriptionType[] ReplenishmentOwnerDescription
        {
            get
            {
                return this.replenishmentOwnerDescriptionField;
            }
            set
            {
                this.replenishmentOwnerDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetServicePercentType TargetServicePercent
        {
            get
            {
                return this.targetServicePercentField;
            }
            set
            {
                this.targetServicePercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetInventoryQuantityType TargetInventoryQuantity
        {
            get
            {
                return this.targetInventoryQuantityField;
            }
            set
            {
                this.targetInventoryQuantityField = value;
            }
        }

        /// <remarks/>
        public PeriodType EffectivePeriod
        {
            get
            {
                return this.effectivePeriodField;
            }
            set
            {
                this.effectivePeriodField = value;
            }
        }

        /// <remarks/>
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public ItemLocationQuantityType ItemLocationQuantity
        {
            get
            {
                return this.itemLocationQuantityField;
            }
            set
            {
                this.itemLocationQuantityField = value;
            }
        }
    }
}