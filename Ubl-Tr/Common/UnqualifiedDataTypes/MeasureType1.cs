namespace UblTr.Common
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TareWeightMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SourceValueMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PreEventNotificationDurationMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PostEventNotificationDurationMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetWeightMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetVolumeMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetTonnageMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetNetWeightMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinimumMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasureType2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaximumMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongitudeMinutesMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongitudeDegreesMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoadingLengthMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LeadTimeMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LatitudeMinutesMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LatitudeDegreesMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GrossWeightMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GrossVolumeMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GrossTonnageMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DurationMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparedValueMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeableWeightMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseUnitMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AltitudeMeasureType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MeasureType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class MeasureType1 : MeasureType
    {
        public static implicit operator MeasureType1(decimal val)
        {
            return new MeasureType1
            {
                Value = val
            };
        }
    }
}