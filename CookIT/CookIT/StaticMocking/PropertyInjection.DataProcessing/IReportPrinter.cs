using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyInjection.DataProcessing
{
    public interface IReportPrinter
    {
        void PrintReport(Person inPerson);
    }
}
