using System;
using Dynamic.DataProcessing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NSubstitute.DataProcessing.Tests
{
    [TestClass]
    public class DataProcessingTests
    {
        [TestMethod]
        public void NSubstitute_ProcessData_validID_callsReportPrinter()
        {
            string oib = "12345678912";
            string name = "Ana";
            string surname = "Anic";
            DateTime dateOfBirth = new DateTime(1988, 6, 6);
            string adress = "Ilica 6";
            string eMail = "ana.anic@fer.hr";
            Person person = new Person(oib, name, surname, dateOfBirth, adress, eMail);

            // Arrange
            var repository = Substitute.For<IPersonRepository>();
            var printer = Substitute.For<IReportPrinter>();

            repository.GetPersonByOib(oib).Returns(person);

            DataProcessor processor = new DataProcessor();
            processor.Repository = (IPersonRepository)repository;
            processor.Printer = (IReportPrinter)printer;

            // Act
            processor.ProcessData(oib);

            // Assert
            printer.Received(1).PrintReport(person);
        }
    }
}
