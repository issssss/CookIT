using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyInjection.DataProcessing
{
    public class DataProcessor
    {
        private IPersonRepository _repository;
        private IReportPrinter _printer;

        public IPersonRepository Repository
        {
            get { return _repository; }
            set { _repository = value; }
        }

        public IReportPrinter Printer
        {
            get { return _printer; }
            set { _printer = value; }
        }

        public DataProcessor()
        {
            _repository = new PersonRepository();
            _printer = new ReportPrinter();
        }

        public void ProcessData(string inOib)
        {
            try
            {
                Person person = _repository.GetPersonByOib(inOib);
                _printer.PrintReport(person);
            }
            catch (PersonDoesNotExistException e)
            {
                throw;
            }
        }
    }
}