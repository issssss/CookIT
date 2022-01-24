using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dynamic.DataProcessing
{
    public interface IReportPrinter
    {
        void PrintReport(Person inPerson);
        void PrintPicture(Person inPerson);
    }
}
