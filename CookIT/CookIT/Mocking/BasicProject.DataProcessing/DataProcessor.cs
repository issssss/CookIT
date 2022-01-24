using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicProject.DataProcessing
{
    public class DataProcessor
    {
        private PersonRepository _repository;
        private ReportPrinter _printer;

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
            catch (Exception)
            {
                throw;
            }

        }
    }
}