namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CataloguePricingUpdateLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CataloguePricingUpdateLineType
    {

        private IDType idField;

        private CustomerPartyType contractorCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private ItemLocationQuantityType[] requiredItemLocationQuantityField;

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
        public CustomerPartyType ContractorCustomerParty
        {
            get
            {
                return this.contractorCustomerPartyField;
            }
            set
            {
                this.contractorCustomerPartyField = value;
            }
        }

        /// <remarks/>
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return this.sellerSupplierPartyField;
            }
            set
            {
                this.sellerSupplierPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity")]
        public ItemLocationQuantityType[] RequiredItemLocationQuantity
        {
            get
            {
                return this.requiredItemLocationQuantityField;
            }
            set
            {
                this.requiredItemLocationQuantityField = value;
            }
        }
    }
}