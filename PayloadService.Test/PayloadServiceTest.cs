using NUnit.Framework;
using Pix.PayloadService;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PayloadServiceTest
    {
        private PayloadService _payloadService;

        [SetUp]
        public void SetUp()
        {
            _payloadService = new PayloadService("brunomarthe72@gmail.com", null, "Bruno Marthe", "Sorocaba SP", "123", "100");
        }

        [Test]
        public void New_Success_Pix_Payload()
        {
            var payload = _payloadService.GetPayload();
            // Console.WriteLine(payload);
            Assert.Equals(payload, "00020126450014br.gov.bcb.pix0123brunomarthe72@gmail.com52040000530398654031005802BR5912Bruno Marthe6011Sorocaba SP620705031236304AF4C");
        }
    }
}