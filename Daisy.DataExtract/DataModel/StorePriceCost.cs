using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

namespace Daisy.DataExtract.DataModel
{
    public class StorePriceCost
    {
        [Name("SKU / UPC_PLU")]
        public string UpcPlu { get; set; }
        [Name("Price Item Group ID")]
        public string PriceItemGroupId { get; set; }
        [Name("Price Item Group Description")]
        public string PriceItemGroupDescription { get; set; }
        [Name("AmountTypeId")]
        public string AmountTypeId { get; set; }
        [Name("AmountTypeDescription")]
        public string AmountTypeDescription { get; set; }
        [Name("StoreNumber")]
        public int StoreNumber { get; set; }
        [Name("Prize Zone ID / Code")]
        public string PriceZoneId { get; set; }
        [Name("Price Zone Description")]
        public string PriceZoneDescription { get; set; }
        [Name("Start Date")]
        public string StartDate { get; set; }
        [Name("End Date")]
        public string EndDate { get; set; }
        [Name("Unit Amount")]
        public decimal UnitAmount { get; set; }
        [Name("Unit of Measure")]
        public string UnitOfMeasure { get; set; }


    }
}
