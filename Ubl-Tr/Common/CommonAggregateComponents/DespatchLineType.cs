namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("DespatchLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DespatchLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private DeliveredQuantityType deliveredQuantityField;

        private OutstandingQuantityType outstandingQuantityField;

        private OutstandingReasonType[] outstandingReasonField;

        private OversupplyQuantityType oversupplyQuantityField;

        private OrderLineReferenceType orderLineReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType itemField;

        private ShipmentType[] shipmentField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeliveredQuantityType DeliveredQuantity
        {
            get
            {
                return this.deliveredQuantityField;
            }
            set
            {
                this.deliveredQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OutstandingQuantityType OutstandingQuantity
        {
            get
            {
                return this.outstandingQuantityField;
            }
            set
            {
                this.outstandingQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OutstandingReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OutstandingReasonType[] OutstandingReason
        {
            get
            {
                return this.outstandingReasonField;
            }
            set
            {
                this.outstandingReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OversupplyQuantityType OversupplyQuantity
        {
            get
            {
                return this.oversupplyQuantityField;
            }
            set
            {
                this.oversupplyQuantityField = value;
            }
        }

        /// <remarks/>
        public OrderLineReferenceType OrderLineReference
        {
            get
            {
                return this.orderLineReferenceField;
            }
            set
            {
                this.orderLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Shipment")]
        public ShipmentType[] Shipment
        {
            get
            {
                return this.shipmentField;
            }
            set
            {
                this.shipmentField = value;
            }
        }
    }
}