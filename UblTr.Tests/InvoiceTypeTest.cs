using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using UblTr.MainDoc;
using UblTr.Serialization;

namespace UblTr.Tests
{
    [TestClass]
    public class InvoiceTypeTest
    {
        private readonly string _basicInvoicePath;
        private readonly string _commercialInvoicePath;

        public InvoiceTypeTest()
        {
            var path = "TestFiles/InvoiceType/";
            _basicInvoicePath = $"{path}BasicInvoice.xml";
            _commercialInvoicePath = $"{path}CommercialInvoice.xml";
        }
        InvoiceType DeserializeInvoiceXml(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(InvoiceType));

            using (StreamReader reader = new StreamReader(path))
            {
                return (InvoiceType)serializer.Deserialize(reader);
            }
        }

        [TestMethod]
        public void InvoiceType_BasicInvoice_Deserialize()
        {
            var invoice = DeserializeInvoiceXml(_basicInvoicePath);
            Assert.AreEqual("GIB20090000000001", invoice.ID.Value);
            Assert.AreEqual("TEMELFATURA", invoice.ProfileID.Value);
            Assert.AreEqual("F47AC10B-58CC-4372-A567-0E02B2C3D479", invoice.UUID.Value);
            Assert.AreEqual("1288331521", invoice.Signature[0].SignatoryParty.PartyIdentification.FirstOrDefault().ID.Value);
            Assert.AreEqual(101, invoice.InvoiceLine.FirstOrDefault().InvoicedQuantity.Value);
        }


        [TestMethod]
        public void InvoiceType_CommercialInvoice_Deserialize()
        {
            var invoice = DeserializeInvoiceXml(_commercialInvoicePath);
            Assert.AreEqual("GIB2009000000011", invoice.ID.Value);
            Assert.AreEqual("TICARIFATURA", invoice.ProfileID.Value);
            Assert.AreEqual("F47AC10B-58CC-4372-A567-0E02B2C3D479", invoice.UUID.Value);
            Assert.AreEqual("1288331521", invoice.Signature[0].SignatoryParty.PartyIdentification.FirstOrDefault().ID.Value);
            Assert.AreEqual(12, invoice.InvoiceLine.FirstOrDefault().InvoicedQuantity.Value);
        }

        [TestMethod]
        public void InvoiceType_BasicInvoice_Serialize()
        {
            var invoice = new InvoiceType
            {
                UUID = new Common.UUIDType() { Value = Guid.NewGuid().ToString() },
                UBLVersionID = new Common.UBLVersionIDType() { Value = "2.1" },
                CustomizationID = new Common.CustomizationIDType() { Value = "TR1.2" },
                ProfileID = new Common.ProfileIDType() { Value = "TEMELFATURA" },
                ID = new Common.IDType() { Value = "INV20200000000001" },
                CopyIndicator = new Common.CopyIndicatorType() { Value = false }
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


    }
}
