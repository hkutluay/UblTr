namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ReceiptLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ReceiptLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private ReceivedQuantityType receivedQuantityField;

        private ShortQuantityType shortQuantityField;

        private RejectedQuantityType rejectedQuantityField;

        private RejectReasonCodeType rejectReasonCodeField;

        private RejectReasonType[] rejectReasonField;

        private OversupplyQuantityType oversupplyQuantityField;

        private ReceivedDateType receivedDateField;

        private TimingComplaintCodeType timingComplaintCodeField;

        private TimingComplaintType timingComplaintField;

        private OrderLineReferenceType orderLineReferenceField;

        private LineReferenceType despatchLineReferenceField;

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
        public ReceivedQuantityType ReceivedQuantity
        {
            get
            {
                return this.receivedQuantityField;
            }
            set
            {
                this.receivedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShortQuantityType ShortQuantity
        {
            get
            {
                return this.shortQuantityField;
            }
            set
            {
                this.shortQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RejectedQuantityType RejectedQuantity
        {
            get
            {
                return this.rejectedQuantityField;
            }
            set
            {
                this.rejectedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RejectReasonCodeType RejectReasonCode
        {
            get
            {
                return this.rejectReasonCodeField;
            }
            set
            {
                this.rejectReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RejectReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RejectReasonType[] RejectReason
        {
            get
            {
                return this.rejectReasonField;
            }
            set
            {
                this.rejectReasonField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReceivedDateType ReceivedDate
        {
            get
            {
                return this.receivedDateField;
            }
            set
            {
                this.receivedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimingComplaintCodeType TimingComplaintCode
        {
            get
            {
                return this.timingComplaintCodeField;
            }
            set
            {
                this.timingComplaintCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimingComplaintType TimingComplaint
        {
            get
            {
                return this.timingComplaintField;
            }
            set
            {
                this.timingComplaintField = value;
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
        public LineReferenceType DespatchLineReference
        {
            get
            {
                return this.despatchLineReferenceField;
            }
            set
            {
                this.despatchLineReferenceField = value;
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