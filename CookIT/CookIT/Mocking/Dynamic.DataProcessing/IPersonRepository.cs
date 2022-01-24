using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dynamic.DataProcessing
{
    public interface IPersonRepository
    {
        Person GetPersonByOib(string inOib);
    }
}
