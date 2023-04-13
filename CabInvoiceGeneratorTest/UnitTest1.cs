using CabInvoiceGeneratorProblem;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        private CabInvoiceGenerator cabInvoiceGenerator;
        [SetUp]
        public void Setup()
        {
            this.cabInvoiceGenerator = new CabInvoiceGenerator();
        }

        [Test]
        public void GivenDistanceAndTime_WhenProper_ShouldReturn_TotalFare()
        {
            double totalFare = this.cabInvoiceGenerator.CalculateFare(3.0, 5.0);
            Assert.AreEqual(35.0, totalFare);
        }
    }
}