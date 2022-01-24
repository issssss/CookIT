using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorInjection.DataProcessing
{
    public class DataProcessor
    {
        private IPersonRepository _repository;
        private IReportPrinter _printer;

        public DataProcessor()
        {
            _repository = new PersonRepository();
            _printer=new ReportPrinter();
        }

        public DataProcessor(IPersonRepository inRepository, IReportPrinter inPrinter)
        {
            _repository = inRepository;
            _printer = inPrinter;
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