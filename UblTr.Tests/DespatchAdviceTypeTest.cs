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
    public class DespatchAdviceTypeTest
    {
        private readonly string _despatchAdvicePath1;
        private readonly string _despatchAdvicePath2;

        public DespatchAdviceTypeTest()
        {
            var path = "TestFiles/DespatchAdviceType/";
            _despatchAdvicePath1 = $"{path}Despatch1.xml";
            _despatchAdvicePath2 = $"{path}Despatch2.xml";
        }
        DespatchAdviceType DeserializeDespatchAdviceXml(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DespatchAdviceType));

            using (StreamReader reader = new StreamReader(path))
            {
                return (DespatchAdviceType)serializer.Deserialize(reader);
            }
        }

        [TestMethod]
        public void DespatchAdviceType_Despatch1_Deserialize()
        {
            var despatch = DeserializeDespatchAdviceXml(_despatchAdvicePath1);
            Assert.AreEqual("GIB2016000000011", despatch.ID.Value);
            Assert.AreEqual("TEMELIRSALIYE", despatch.ProfileID.Value);
            Assert.AreEqual("F47AC10B-58CC-4372-A567-0E02B2C3D479", despatch.UUID.Value);
            Assert.AreEqual("1288331521", despatch.Signature[0].SignatoryParty.PartyIdentification.FirstOrDefault().ID.Value);
            Assert.AreEqual(20, despatch.DespatchLine.FirstOrDefault().DeliveredQuantity.Value);
        }


        [TestMethod]
        public void DespatchAdviceType_Despatch2_Deserialize()
        {
            var despatch = DeserializeDespatchAdviceXml(_despatchAdvicePath2);
            Assert.AreEqual("GIB2016000000012", despatch.ID.Value);
            Assert.AreEqual("TEMELIRSALIYE", despatch.ProfileID.Value);
            Assert.AreEqual("F47AC10B-58CC-4372-A567-0E02B2C3D479", despatch.UUID.Value);
            Assert.AreEqual("1288331521", despatch.Signature[0].SignatoryParty.PartyIdentification.FirstOrDefault().ID.Value);
            Assert.AreEqual(10, despatch.DespatchLine.FirstOrDefault().DeliveredQuantity.Value);
        }
    

        [TestMethod]
        public void DespatchAdviceType_Sample_Serialize()
        {
            var despatch = new DespatchAdviceType
            {
                UUID = new Common.UUIDType() { Value = Guid.NewGuid().ToString() },
                UBLVersionID = new Common.UBLVersionIDType() { Value = "2.1" },
                CustomizationID = new Common.CustomizationIDType() { Value = "TR1.2" },
                ProfileID = new Common.ProfileIDType() { Value = "TEMELIRSALIYE" },
                ID = new Common.IDType() { Value = "IRS20200000000001" },
                CopyIndicator = new Common.CopyIndicatorType() { Value = false }
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DespatchAdviceType));
            var stream = new MemoryStream();
            xmlSerializer.Serialize(stream, despatch, new UblTrNamespaces());
            stream.Seek(0,SeekOrigin.Begin);

            var deserializedDespatch = (DespatchAdviceType)xmlSerializer.Deserialize(stream);

            Assert.AreEqual(despatch.ID.Value, deserializedDespatch.ID.Value);
            Assert.AreEqual(despatch.UUID.Value, deserializedDespatch.UUID.Value);
            Assert.AreEqual(despatch.CustomizationID.Value, deserializedDespatch.CustomizationID.Value);
            Assert.AreEqual(despatch.CopyIndicator.Value, deserializedDespatch.CopyIndicator.Value);
            Assert.AreEqual(despatch.ProfileID.Value, deserializedDespatch.ProfileID.Value);
        }


    }
}
