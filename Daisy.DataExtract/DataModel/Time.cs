using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Daisy.DataExtract.DataModel
{
    class Time
    {
        [Name("Date")]
        public DateTime Date { get; set; }

        [Name("Calendar Week")]
        public string CalendarWeek { get; set; }

        [Name("Promo Week")]
        public string PromoWeek { get; set; }

        [Name("Promo Period")]
        public string PromoPeriod { get; set; }

        [Name("Fiscal Week")]
        public string FiscalWeek { get; set; }

        [Name("Fiscal Period")]
        public string FiscalPeriod { get; set; }

        [Name("Fiscal Quarter")]
        public string FiscalQuarter { get; set; }

        [Name("Fiscal Year")]
        public int FiscalYear { get; set; }

    }
}
