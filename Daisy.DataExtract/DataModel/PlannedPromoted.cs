using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Daisy.DataExtract.DataModel
{
    class PlannedPromoted
    {
        [Name("Promo Number")]
        public int PromoNumber { get; set; }

        [Name("Promo Type ID")]
        public int PromoTypeID { get; set; }

        [Name("Promo Start Date")]
        public DateTime PromoStartDate { get; set; }

        [Name("Promo End Date")]
        public DateTime PromoEndDate { get; set; }

        [Name("Store Number")]
        public int StoreNumber { get; set; }

        [Name("SKU / UPC_PLU")]
        public int UpcPlu { get; set; }

        [Name("SKU Description")]
        public string SkuDescription { get; set; }

        [Name("Promo Price")]
        public decimal PromoPrice { get; set; }

        [Name("Page Number")]
        public int PageNumber { get; set; }

        [Name("Page Section")]
        public string PageSection { get; set; }
    }
}
