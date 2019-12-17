using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Daisy.DataExtract.DataModel
{
    class ReconciliationTotals
    {
        [Name("Date")]
        public DateTime Date { get; set; }

        [Name("Promo Week")]
        public string PromoWeek { get; set; }

        [Name("Store Number")]
        public int StoreNumber { get; set; }

        [Name("Promo ID")]
        public int PromoId { get; set; }

        [Name("Product Hierarchy Level Name")]
        public string ProductHierarchyLevelName { get; set; }

        [Name("Hierarchy Value")]
        public int HierarchyValue { get; set; }

        [Name("Net Sales Sum")]
        public decimal NetSalesSum { get; set; }

        [Name("Count of Transactions")]
        public int CountofTransactions { get; set; }
    }
}
