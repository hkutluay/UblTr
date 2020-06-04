# DespatchAdviceType Sample Usage


First install UblTr NuGet package:
```
PM> Install-Package UblTr
```

## Serialize
```csharp
private static void Main(string[] args)
{
      var despatch = new UblTr.MainDoc.DespatchAdviceType()
      {
            UUID = new UblTr.Common.UUIDType() { Value = Guid.NewGuid().ToString() },
            UBLVersionID = new UblTr.Common.UBLVersionIDType() { Value = "2.1" },
            CustomizationID = new UblTr.Common.CustomizationIDType() { Value = "TR1.2" },
            ProfileID = new UblTr.Common.ProfileIDType() { Value = "TEMELIRSALIYE" },
            ID = new UblTr.Common.IDType() { Value = "IRS20200000000001" },
            CopyIndicator = new UblTr.Common.CopyIndicatorType() { Value = false }
      };

      XmlSerializer xmlSerializer = new XmlSerializer(typeof(UblTr.MainDoc.DespatchAdviceType));
      using TextWriter writer = new StreamWriter(@"C:\Temp\TestDespatch.xml"); //path to document
      xmlSerializer.Serialize(writer, invoice, new UblTr.Serialization.UblTrNamespaces());
}

 ```
 
**Xml file content**
 ```xml
<?xml version="1.0"?>

<DespatchAdvice xmlns="urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2" 
xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" 
xmlns:xades="http://uri.etsi.org/01903/v1.3.2#" 
xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2" 
xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2" 
xmlns:ubltr="urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents" 
xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2" 
xmlns:ds="http://www.w3.org/2000/09/xmldsig#" 
xmlns:ccts="urn:un:unece:uncefact:documentation:2" 
xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" 
xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2">
  <cbc:UBLVersionID>2.1</cbc:UBLVersionID>
  <cbc:CustomizationID>TR1.2</cbc:CustomizationID>
  <cbc:ProfileID>TEMELIRSALIYE</cbc:ProfileID>
  <cbc:ID>IRS20200000000001</cbc:ID>
  <cbc:CopyIndicator>false</cbc:CopyIndicator>
  <cbc:UUID>c7c2198e-a90a-4e04-8958-b9393de6bd60</cbc:UUID>
</DespatchAdvice>
 ```

## Deserialize
```csharp

var path = @"C:\Temp\TestDespatch.xml"; // path to despatch document
XmlSerializer serializer = new XmlSerializer(typeof(UblTr.MainDoc.DespatchAdviceType));

using (StreamReader reader = new StreamReader(path))
{
      var despatch = (UblTr.MainDoc.DespatchAdviceType)serializer.Deserialize(reader);
}
 ```
 
