namespace UblTr.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TransportExecutionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportExecutionTermsType
    {

        private TransportUserSpecialTermsType[] transportUserSpecialTermsField;

        private TransportServiceProviderSpecialTermsType[] transportServiceProviderSpecialTermsField;

        private ChangeConditionsType[] changeConditionsField;

        private PaymentTermsType[] paymentTermsField;

        private DeliveryTermsType[] deliveryTermsField;

        private PaymentTermsType bonusPaymentTermsField;

        private PaymentTermsType commissionPaymentTermsField;

        private PaymentTermsType penaltyPaymentTermsField;

        private EnvironmentalEmissionType[] environmentalEmissionField;

        private NotificationRequirementType[] notificationRequirementField;

        private PaymentTermsType serviceChargePaymentTermsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportUserSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportUserSpecialTermsType[] TransportUserSpecialTerms
        {
            get
            {
                return this.transportUserSpecialTermsField;
            }
            set
            {
                this.transportUserSpecialTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportServiceProviderSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportServiceProviderSpecialTermsType[] TransportServiceProviderSpecialTerms
        {
            get
            {
                return this.transportServiceProviderSpecialTermsField;
            }
            set
            {
                this.transportServiceProviderSpecialTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChangeConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChangeConditionsType[] ChangeConditions
        {
            get
            {
                return this.changeConditionsField;
            }
            set
            {
                this.changeConditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return this.paymentTermsField;
            }
            set
            {
                this.paymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms")]
        public DeliveryTermsType[] DeliveryTerms
        {
            get
            {
                return this.deliveryTermsField;
            }
            set
            {
                this.deliveryTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType BonusPaymentTerms
        {
            get
            {
                return this.bonusPaymentTermsField;
            }
            set
            {
                this.bonusPaymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType CommissionPaymentTerms
        {
            get
            {
                return this.commissionPaymentTermsField;
            }
            set
            {
                this.commissionPaymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType PenaltyPaymentTerms
        {
            get
            {
                return this.penaltyPaymentTermsField;
            }
            set
            {
                this.penaltyPaymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmission")]
        public EnvironmentalEmissionType[] EnvironmentalEmission
        {
            get
            {
                return this.environmentalEmissionField;
            }
            set
            {
                this.environmentalEmissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotificationRequirement")]
        public NotificationRequirementType[] NotificationRequirement
        {
            get
            {
                return this.notificationRequirementField;
            }
            set
            {
                this.notificationRequirementField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType ServiceChargePaymentTerms
        {
            get
            {
                return this.serviceChargePaymentTermsField;
            }
            set
            {
                this.serviceChargePaymentTermsField = value;
            }
        }
    }
}