using System;
using Dynamic.DataProcessing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace NMock.DataProcessing.Tests
{
    [TestFixture]
    public class DataProcessingTests
    {
        [Test]
        public void NMock_ProcessData_validID_callsReportPrinter()
        {
            string oib = "12345678912";
            string name = "Ana";
            string surname = "Anic";
            DateTime dateOfBirth = new DateTime(1988, 6, 6);
            string adress = "Ilica 6";
            string eMail = "ana.anic@fer.hr";
            Person person = new Person(oib, name, surname, dateOfBirth, adress, eMail);

            MockFactory _factory = new MockFactory();

            var mockRepository = _factory.CreateMock<IPersonRepository>();
            var mockPrinter = _factory.CreateMock<IReportPrinter>();

            DataProcessor processor = new DataProcessor
            {
                Repository = mockRepository.MockObject,
                Printer = mockPrinter.MockObject
            };

            //expectations
            mockRepository.Expects.One.MethodWith(_ => _.GetPersonByOib(oib)).WillReturn(person);
            mockPrinter.Expects.One.MethodWith(_ => _.PrintReport(person));

            //start
            processor.ProcessData(oib);

            _factory.VerifyAllExpectationsHaveBeenMet();
        }
/*
        [Test]
        [NUnit.Framework.ExpectedException(typeof(PersonDoesNotExistException))]
        public void ProcessData_invalidID_throwsException()
        {
            Mockery mockery = new Mockery();

            IPersonRepository repository = (IPersonRepository)mockery.NewMock(typeof(IPersonRepository));
            IReportPrinter printer = (IReportPrinter)mockery.NewMock(typeof(IReportPrinter));

            DataProcessor processor = new DataProcessor();
            processor.Repository = repository;
            processor.Printer = printer;

            //expectations
            Expect.Once.On(repository).Method("GetPersonByOib").Will(Throw.Exception(new PersonDoesNotExistException()));

            //start
            processor.ProcessData("12345678913");
        }
        */
    }
}

