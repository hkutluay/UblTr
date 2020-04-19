using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml.Serialization;
using UblTr.MainDoc;
using System.Linq;
using System;
using System.Text;
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
            var invoice = new InvoiceType();
            invoice.UUID = new Common.UUIDType() { Value = Guid.NewGuid().ToString() };
            invoice.UBLVersionID = new Common.UBLVersionIDType() { Value = "2.1" };
            invoice.CustomizationID = new Common.CustomizationIDType() { Value = "TR1.2" };
            invoice.ProfileID = new Common.ProfileIDType() { Value = "TEMELFATURA" };
            invoice.ID = new Common.IDType() { Value = "INV20200000000001" };
            invoice.CopyIndicator = new Common.CopyIndicatorType() { Value = false };


            XmlSerializer xmlSerializer = new XmlSerializer(typeof(InvoiceType));
            TextWriter writer = new StreamWriter(@"C:\Temp\TestInvoice.xml");
            xmlSerializer.Serialize(writer, invoice, new UblTrNamespaces());

        }


    }
}
