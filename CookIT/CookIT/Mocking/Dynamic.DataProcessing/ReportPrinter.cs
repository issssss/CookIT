using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dynamic.DataProcessing
{
    public class ReportPrinter : IReportPrinter
    {
        public void PrintReport(Person inPerson)
        {
            //stvoriti novo izvješće pomoću Crystal Reportsa
            //povezati podatke
            //prikazati podatke na korisničkom sučelju
        }


        public void PrintPicture(Person inPerson)
        {
            //dohvaca se slika osobe
            //povezuju se podaci
            //prikazuje se slika osobe na korisnickom sucelju
        }
    }
}
