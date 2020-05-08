namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AppealTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AppealTermsType
    {

        private DescriptionType[] descriptionField;

        private PeriodType presentationPeriodField;

        private PartyType appealInformationPartyField;

        private PartyType appealReceiverPartyField;

        private PartyType mediationPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public PeriodType PresentationPeriod
        {
            get
            {
                return this.presentationPeriodField;
            }
            set
            {
                this.presentationPeriodField = value;
            }
        }

        /// <remarks/>
        public PartyType AppealInformationParty
        {
            get
            {
                return this.appealInformationPartyField;
            }
            set
            {
                this.appealInformationPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType AppealReceiverParty
        {
            get
            {
                return this.appealReceiverPartyField;
            }
            set
            {
                this.appealReceiverPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType MediationParty
        {
            get
            {
                return this.mediationPartyField;
            }
            set
            {
                this.mediationPartyField = value;
            }
        }
    }
}