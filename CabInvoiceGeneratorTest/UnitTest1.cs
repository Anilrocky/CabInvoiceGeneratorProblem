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
        [Test]
        public void GivenDistanceAndTimeForMultipleRides_WhenProper_ShouldReturn_AggregateFare()
        {
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
            InvoiceSummary invoiceSummary = this.cabInvoiceGenerator.GetMultipleRideFare(ride);
            Assert.AreEqual(60.0, invoiceSummary.totalFare);
        }
        [Test]
        public void GivenUserIdForMultipleRides_WhenProper_ShouldReturn_InvoiceSummary()
        {
            CabInvoiceGenerator repository = new CabInvoiceGenerator();
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
            repository.MapRidesToUser("anil", ride);
            InvoiceSummary summary = repository.GetInvoiceSummary("anil");
            Assert.AreEqual(summary.totalFare, 60.0);
        }
    }
}