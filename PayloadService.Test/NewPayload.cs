using NUnit.Framework;
using Pix.PayloadService;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PayloadService _payloadService;

        [SetUp]
        public void SetUp()
        {
            _payloadService = new PayloadService("brunomarthe72@gmail.com", null, "Bruno Marthe", "Sorocaba SP", "123", "100");
        }

        [Test]
        public void NewPayload()
        {
            var payload = _payloadService.GetPayload();
            Console.WriteLine(payload);
            if(payload == "00020126450014br.gov.bcb.pix0123brunomarthe72@gmail.com52040000530398654031005802BR5912Bruno Marthe6011Sorocaba SP620705031236304AF4C"){
                Assert.IsTrue(true, "Ok");
            }

            Assert.IsFalse(true, "Payload cod invalid");
        }
    }
}