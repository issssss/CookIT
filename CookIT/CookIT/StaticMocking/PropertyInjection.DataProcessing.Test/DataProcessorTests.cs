using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using PropertyInjection.DataProcessing;
using NUnit.Framework;

namespace PropertyInjection.DataProcessing.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestFixture]
    public class DataProcessorTests
    {
        [Test]
        public void ProcessData_validID_callsReportPrinter()
        {
            PersonRepositoryStub_OK repository = new PersonRepositoryStub_OK();
            string oib = "12345678912";
            string name = "Ana";
            string surname = "Anic";
            DateTime dateOfBirth = new DateTime(1988, 6, 6);
            string adress = "Ilica 6";
            string eMail = "ana.anic@fer.hr";

            repository.Person = new Person(oib, name, surname, dateOfBirth, adress, eMail);
            ReportPrinterMock printer=new ReportPrinterMock();
            DataProcessor processor = new DataProcessor();
            processor.Repository = repository;
            processor.Printer = printer;
            processor.ProcessData(oib);

            Assert.AreEqual(oib, printer.Oib);
            Assert.AreEqual(name, printer.Name);
            Assert.AreEqual(surname, printer.Surname);
            Assert.AreEqual(dateOfBirth, printer.DateOfBirth);
            Assert.AreEqual(adress, printer.Adress);
            Assert.AreEqual(eMail, printer.EMail);
        }

        [Test]
        [NUnit.Framework.ExpectedException(typeof(PersonDoesNotExistException))]
        public void ProcessData_invalidID_throwsException()
        {
            PersonRepositoryStub_Exception repository = new PersonRepositoryStub_Exception();
            repository.ToThrow=new PersonDoesNotExistException();
            IReportPrinter printer = new ReportPrinterMock();
            DataProcessor processor = new DataProcessor();
            processor.Repository = repository;
            processor.Printer = printer;
            processor.ProcessData("12345678913");
        }
    }

    public class PersonRepositoryStub_OK : IPersonRepository
    {
        public Person Person;

        public Person GetPersonByOib(string inOib)
        {
            return Person;
        }
    }

    public class PersonRepositoryStub_Exception : IPersonRepository
    {
        public PersonDoesNotExistException ToThrow;

        public Person GetPersonByOib(string inOib)
        {
            throw ToThrow;
        }
    }
    
    public class ReportPrinterMock : IReportPrinter
    {
        public string Oib;
        public string Name;
        public string Surname;
        public DateTime DateOfBirth;
        public string Adress;
        public string EMail;

        public void PrintReport(Person inPerson)
        {
            Oib = inPerson.Oib;
            Name = inPerson.Name;
            Surname = inPerson.Surname;
            DateOfBirth = inPerson.DateOfBirth;
            Adress = inPerson.Adress;
            EMail = inPerson.EMail;
        }
    }
}
