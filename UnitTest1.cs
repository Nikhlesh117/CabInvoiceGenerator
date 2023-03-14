using CabInvoiceGenerator;
namespace NUnitInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {

        InvoiceGenerator invoiceGenerator = null;

        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
    }
}