using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyInjection.DataProcessing
{
    public class PersonRepository:IPersonRepository
    {
        public Person GetPersonByOib(string inOib)
        {
            //uspostaviti konekciju na bazu
            //obaviti upit pretrage prema ulaznom oib-u
            //ukoliko osoba postoji vratiti učitanu osobu
            //ukoliko osoba ne postoji baciti iznimku
            return null;
        }
    }
}
