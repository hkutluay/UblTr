using System.Xml;
using System.Xml.Serialization;

namespace UblTr.Serialization
{
    public class UblTrNamespaces : XmlSerializerNamespaces
    {
        public UblTrNamespaces()
        {
            Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            Add("ccts", "urn:un:unece:uncefact:documentation:2");
            Add("ds", "http://www.w3.org/2000/09/xmldsig#");
            Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            Add("ubltr", "urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents");
            Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
            Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
            Add("xades", "http://uri.etsi.org/01903/v1.3.2#");
            Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }
    }

    public class UblTrNamespacesManager : XmlNamespaceManager
    {
        public UblTrNamespacesManager(XmlNameTable TableName): base(TableName)
        {
            AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            AddNamespace("ccts", "urn:un:unece:uncefact:documentation:2");
            AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#");
            AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            AddNamespace("ubltr", "urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents");
            AddNamespace("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
            AddNamespace("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
            AddNamespace("xades", "http://uri.etsi.org/01903/v1.3.2#");
            AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        }

    }
}