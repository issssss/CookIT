using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyInjection.DataProcessing
{
    public interface IPersonRepository
    {
        Person GetPersonByOib(string inOib);
    }
}
