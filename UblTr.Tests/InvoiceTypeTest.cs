using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using UblTr.MainDoc;
using UblTr.Serialization;
using System.Globalization;

namespace UblTr.Tests
{
    [TestClass]
    public class InvoiceTypeTest
    {
        private readonly string _testFilesPath;
        private readonly string _testBinariesPath;
      
        public InvoiceTypeTest()
        {
             _testFilesPath = "TestFiles/InvoiceType";
             _testBinariesPath = "TestFiles/Binaries";
        }

        static InvoiceType DeserializeInvoiceXml(string path)
        {
            var serializer = new XmlSerializer(typeof(InvoiceType));

            using var reader = new StreamReader(path);
            return (InvoiceType)serializer.Deserialize(reader);
        }

        [TestMethod]
        public void InvoiceType_BasicInvoice_Deserialize()
        {
            var invoice = DeserializeInvoiceXml($"{_testFilesPath}/BasicInvoice.xml");
            Assert.AreEqual("GIB20090000000001", invoice.ID.Value);
            Assert.AreEqual("TEMELFATURA", invoice.ProfileID.Value);
            Assert.AreEqual("F47AC10B-58CC-4372-A567-0E02B2C3D479", invoice.UUID.Value);
            Assert.AreEqual("1288331521", invoice.Signature[0].SignatoryParty.PartyIdentification.FirstOrDefault().ID.Value);
            Assert.AreEqual(101, invoice.InvoiceLine.FirstOrDefault().InvoicedQuantity.Value);
            Assert.AreEqual("14:42:00", invoice.IssueTime.Value.ToString("HH:mm:ss", CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void InvoiceType_BasicInvoiceLongTimeWithZone3f_Deserialize()
        {
            var invoice = DeserializeInvoiceXml( $"{_testFilesPath}/BasicInvoiceLongTimeWithZone3f.xml");
            Assert.AreEqual("23:30:41", TimeZoneInfo.ConvertTimeToUtc(invoice.IssueTime.Value).ToString("HH:mm:ss"));
        }

        [TestMethod]
        public void InvoiceType_BasicInvoiceLongTime7f_Deserialize()
        {
            var invoice = DeserializeInvoiceXml( $"{_testFilesPath}/BasicInvoiceLongTime7f.xml");
            Assert.AreEqual("15:21:06", TimeZoneInfo.ConvertTimeToUtc(invoice.IssueTime.Value).ToString("HH:mm:ss"));
        }

         [TestMethod]
        public void InvoiceType_BasicInvoiceLongTime_Deserialize()
        {
            var invoice = DeserializeInvoiceXml( $"{_testFilesPath}/BasicInvoiceLongTime.xml");
            Assert.AreEqual("17:11:02", TimeZoneInfo.ConvertTimeToUtc(invoice.IssueTime.Value).ToString("HH:mm:ss"));
        }


         [TestMethod]
        public void InvoiceType_BasicInvoiceHourMinute_Deserialize()
        {
            var invoice = DeserializeInvoiceXml( $"{_testFilesPath}/BasicInvoiceHourMinuteTime.xml");
            Assert.AreEqual("14:42", invoice.IssueTime.Value.ToString("HH:mm", CultureInfo.InvariantCulture));
        }

        [TestMethod]
        public void InvoiceType_BasicInvoiceIncorrectTime_Deserialize()
        {
            Assert.ThrowsException<System.InvalidOperationException>(() =>
            {
               var invoice = DeserializeInvoiceXml($"{_testFilesPath}/BasicInvoiceIncorrectTime.xml");
            });
        }

        [TestMethod]
        public void InvoiceType_BasicInvoiceNoTime_Deserialize()
        {
            var invoice = DeserializeInvoiceXml($"{_testFilesPath}/BasicInvoiceNoTime.xml");
            Assert.IsNull(invoice.IssueTime);
        }

        [TestMethod]
        public void InvoiceType_BasicInvoiceInvalidAdditionalDocument_Deserialize()
        {
            var invoice = DeserializeInvoiceXml($"{_testFilesPath}/BasicInvoiceInvalidAdditionalDocument.xml");
            Assert.AreEqual("GIB20090000000001", invoice.ID.Value);
            Assert.AreEqual("TEMELFATURA", invoice.ProfileID.Value);
            Assert.AreEqual("F47AC10B-58CC-4372-A567-0E02B2C3D479", invoice.UUID.Value);
            Assert.AreEqual("1", invoice.AdditionalDocumentReference.FirstOrDefault().ID.Value);
            Assert.AreEqual("QRCODE", invoice.AdditionalDocumentReference.FirstOrDefault().DocumentType.Value);
        }

        [TestMethod]
        public void InvoiceType_BasicInvoiceValidAdditionalDocument_Deserialize()
        {
            var invoice = DeserializeInvoiceXml($"{_testFilesPath}/BasicInvoiceValidAdditionalDocument.xml");
            Assert.AreEqual("GIB20090000000001", invoice.ID.Value);
            Assert.AreEqual("TEMELFATURA", invoice.ProfileID.Value);
            Assert.AreEqual("F47AC10B-58CC-4372-A567-0E02B2C3D479", invoice.UUID.Value);
            Assert.AreEqual(1,invoice.AdditionalDocumentReference.Count());
            var firstAdditionalDocument = invoice.AdditionalDocumentReference.FirstOrDefault();
            Assert.AreEqual("1", firstAdditionalDocument.ID.Value);
            Assert.AreEqual("QRCODE", firstAdditionalDocument.DocumentType.Value);
            Assert.IsNotNull(firstAdditionalDocument.Attachment.EmbeddedDocumentBinaryObject.Value);
             var bytes = File.ReadAllBytes($"{_testBinariesPath}/qr.png");
            Assert.AreEqual(bytes.Length, firstAdditionalDocument.Attachment.EmbeddedDocumentBinaryObject.Value.Length);
            Assert.IsTrue(bytes.SequenceEqual(firstAdditionalDocument.Attachment.EmbeddedDocumentBinaryObject.Value));
        }


        [TestMethod]
        public void InvoiceType_CommercialInvoice_Deserialize()
        {
            var invoice = DeserializeInvoiceXml($"{_testFilesPath}/CommercialInvoice.xml");
            Assert.AreEqual("GIB2009000000011", invoice.ID.Value);
            Assert.AreEqual("TICARIFATURA", invoice.ProfileID.Value);
            Assert.AreEqual("F47AC10B-58CC-4372-A567-0E02B2C3D479", invoice.UUID.Value);
            Assert.AreEqual("1288331521", invoice.Signature[0].SignatoryParty.PartyIdentification.FirstOrDefault().ID.Value);
            Assert.AreEqual(12, invoice.InvoiceLine.FirstOrDefault().InvoicedQuantity.Value);
            Assert.AreEqual("14:42:00", invoice.IssueTime.Value.ToString("HH:mm:ss"));
        }

        [TestMethod]
        public void InvoiceType_BasicInvoice_Serialize()
        {
            var document = new XmlDocument();
            var date = DateTime.Now;

            var invoice = new InvoiceType
            {
                UUID = Guid.NewGuid().ToString(),
                UBLVersionID = "2.1",
                CustomizationID = "TR1.2",
                ProfileID = "TEMELFATURA",
                ID = "INV20200000000001",
                CopyIndicator = false,
                UBLExtensions = new Common.UBLExtensionType[] {
                   new Common.UBLExtensionType() {
                    ExtensionContent  =   document.CreateElement("auto-generated_for_wildcard","n4")
                    }
                },
                IssueTime = date,
                IssueDate = date
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(InvoiceType));
            var stream = new MemoryStream();
            xmlSerializer.Serialize(stream, invoice, new UblTrNamespaces());
            stream.Seek(0,SeekOrigin.Begin);

            var deserializedInvoice = (InvoiceType)xmlSerializer.Deserialize(stream);

            Assert.AreEqual(invoice.ID.Value, deserializedInvoice.ID.Value);
            Assert.AreEqual(invoice.UUID.Value, deserializedInvoice.UUID.Value);
            Assert.AreEqual(invoice.CustomizationID.Value, deserializedInvoice.CustomizationID.Value);
            Assert.AreEqual(invoice.CopyIndicator.Value, deserializedInvoice.CopyIndicator.Value);
            Assert.AreEqual(invoice.ProfileID.Value, deserializedInvoice.ProfileID.Value);
        }

        [TestMethod]
        public void InvoiceType_BasicInvoice_TimeSerialize()
        {
            var document = new XmlDocument();

            // var date = DateTime.ParseExact("2022/01/01 22:30:44", "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
            var date = DateTime.Now;
            var invoice = new InvoiceType
            {
                UUID =  Guid.NewGuid().ToString(),
                UBLVersionID =  "2.1",
                CustomizationID =  "TR1.2",
                ProfileID =  "TEMELFATURA",
                ID =  "INV20200000000001",
                CopyIndicator =  false,
                UBLExtensions = new Common.UBLExtensionType[] {
                   new Common.UBLExtensionType() {
                    ExtensionContent  =   document.CreateElement("auto-generated_for_wildcard","n4")
                    }
                },
                IssueTime = date,
                IssueDate = date
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(InvoiceType));
            var stream = new MemoryStream();
            xmlSerializer.Serialize(stream, invoice, new UblTrNamespaces());
            stream.Seek(0, SeekOrigin.Begin);

            var xPath = @"//*[local-name() = 'Invoice']/cbc:IssueTime";

            var doc = new XmlDocument();
            var namespaces = new UblTrNamespacesManager(doc.NameTable);
            doc.Load(stream);
            var sn = doc.SelectSingleNode(xPath, namespaces);
          
            Assert.AreEqual(date.ToString("HH:mm:ss"), sn.InnerText);
        }
    }
}
