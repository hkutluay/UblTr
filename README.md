# Ubl-Tr

C# proxy classes to create and serialize .Net objects to Xml that conforms [UBL-TR v1.2.1](https://www.oasis-open.org/committees/sc_home.php?wg_abbrev=ubl-trlsc#en) standards or deserialize UBL-Tr documents to .Net objects.

# Sample Usage


First install UblTr package:
```
PM> Install-Package UblTr
```

## Serialize
```csharp
var invoice = new InvoiceType(); 
invoice.UUID = new Common.UUIDType() { Value = Guid.NewGuid().ToString() };
invoice.UBLVersionID = new Common.UBLVersionIDType() { Value = "2.1" };
invoice.CustomizationID = new Common.CustomizationIDType() { Value = "TR1.2" };
invoice.ProfileID = new Common.ProfileIDType() { Value = "TEMELFATURA" };
invoice.ID = new Common.IDType() { Value = "INV20200000000001" };
invoice.CopyIndicator = new Common.CopyIndicatorType() { Value = false };

var namespaces = new XmlSerializerNamespaces();
namespaces.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
namespaces.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
namespaces.Add("ccts", "urn:un:unece:uncefact:documentation:2");
namespaces.Add("ds", "http://www.w3.org/2000/09/xmldsig#");
namespaces.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
namespaces.Add("ubltr", "urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents");
namespaces.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
namespaces.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
namespaces.Add("xades", "http://uri.etsi.org/01903/v1.3.2#");
namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

XmlSerializer xmlSerializer = new XmlSerializer(typeof(InvoiceType));
TextWriter writer = new StreamWriter(@"C:\Temp\TestInvoice.xml"); //path to document
xmlSerializer.Serialize(writer, invoice, namespaces);

 ```
 
**Xml file content**
 ```xml
<?xml version="1.0" encoding="utf-8"?>
<Invoice xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" 
xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" 
xmlns:ccts="urn:un:unece:uncefact:documentation:2" 
xmlns:ds="http://www.w3.org/2000/09/xmldsig#" 
xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2" 
xmlns:ubltr="urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents" 
xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2" 
xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2" 
xmlns:xades="http://uri.etsi.org/01903/v1.3.2#" 
xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" 
xmlns="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2">
  <cbc:UBLVersionID>2.1</cbc:UBLVersionID>
  <cbc:CustomizationID>TR1.2</cbc:CustomizationID>
  <cbc:ProfileID>TEMELFATURA</cbc:ProfileID>
  <cbc:ID>INV20200000000001</cbc:ID>
  <cbc:CopyIndicator>false</cbc:CopyIndicator>
  <cbc:UUID>fa595ae1-9ba4-4661-a031-6c58a53e7429</cbc:UUID>
</Invoice>
 ```

## Deserialize
```csharp

var path = @"C:\invoice.xml"; // path to invoice document
XmlSerializer serializer = new XmlSerializer(typeof(InvoiceType));

using (StreamReader reader = new StreamReader(path))
{
      var invoice = (InvoiceType)serializer.Deserialize(reader);
}
 ```
 
