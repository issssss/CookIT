using System;
using Dynamic.DataProcessing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Moq.DataProcessing.Tests
{
    [TestClass]
    public class DataProcessingTests
    {
        [TestMethod]
        public void Moq_ProcessData_validID_callsReportPrinter()
        {
            string oib = "12345678912";
            string name = "Ana";
            string surname = "Anic";
            DateTime dateOfBirth = new DateTime(1988, 6, 6);
            string adress = "Ilica 6";
            string eMail = "ana.anic@fer.hr";
            Person person = new Person(oib, name, surname, dateOfBirth, adress, eMail);

            // Arrange
            var repository = new Mock<IPersonRepository>();
            var printer = new Mock<IReportPrinter>();

            repository.Setup(x => x.GetPersonByOib(oib)).Returns(person);
            //			printer.Setup(x => x.PrintReport(person));

            DataProcessor processor = new DataProcessor();
            processor.Repository = (IPersonRepository)repository.Object;
            processor.Printer = (IReportPrinter)printer.Object;

            // Act
            processor.ProcessData(oib);

            // Assert
            printer.Verify(x => x.PrintReport(person), Times.Once);
        }
    }
}
