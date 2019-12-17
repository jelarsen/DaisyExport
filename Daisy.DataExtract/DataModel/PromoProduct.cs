using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Daisy.DataExtract.DataModel
{
    class PromoProduct
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

        [Name("Page Number")]
        public int PageNumber { get; set; }
    }
}
