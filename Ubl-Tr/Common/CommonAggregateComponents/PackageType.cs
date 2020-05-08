namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ActualPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PackageType
    {

        private IDType idField;

        private QuantityType2 quantityField;

        private ReturnableMaterialIndicatorType returnableMaterialIndicatorField;

        private PackageLevelCodeType packageLevelCodeField;

        private PackagingTypeCodeType packagingTypeCodeField;

        private PackingMaterialType[] packingMaterialField;

        private PackageType[] containedPackageField;

        private GoodsItemType[] goodsItemField;

        private DimensionType[] measurementDimensionField;

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
        public QuantityType2 Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReturnableMaterialIndicatorType ReturnableMaterialIndicator
        {
            get
            {
                return this.returnableMaterialIndicatorField;
            }
            set
            {
                this.returnableMaterialIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackageLevelCodeType PackageLevelCode
        {
            get
            {
                return this.packageLevelCodeField;
            }
            set
            {
                this.packageLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackagingTypeCodeType PackagingTypeCode
        {
            get
            {
                return this.packagingTypeCodeField;
            }
            set
            {
                this.packagingTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PackingMaterial", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackingMaterialType[] PackingMaterial
        {
            get
            {
                return this.packingMaterialField;
            }
            set
            {
                this.packingMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContainedPackage")]
        public PackageType[] ContainedPackage
        {
            get
            {
                return this.containedPackageField;
            }
            set
            {
                this.containedPackageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
        public GoodsItemType[] GoodsItem
        {
            get
            {
                return this.goodsItemField;
            }
            set
            {
                this.goodsItemField = value;
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
    }
}