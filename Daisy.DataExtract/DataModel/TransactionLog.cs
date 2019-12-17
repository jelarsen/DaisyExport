using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Daisy.DataExtract.DataModel
{
    public class TransactionLog
    {
        [Name("Transaction Date")]
        public string TransactionDate { get; set; }

        [Name("Transaction ID")]
        public string TransactionId { get; set; }

        [Name("Register Number")]
        public string RegisterNumber { get; set; }

        [Name("Transaction Line Number / Sequence")]
        public int TransactionLineNumber { get; set; }

        [Name("StoreNumber")]
        public int StoreNumber { get; set; }

        [Name("Location ID")]
        public string LocationId { get; set; }

        [Name("SKU / UPC_PLU")]
        public string UpcPlu { get; set; }

        [Name("Customer ID")]
        public string CustomerId { get; set; }

        [Name("Net Sales Amount")]
        public decimal NetSalesAmount { get; set; }

        [Name("Unit Price")]
        public decimal? UnitPrice { get; set; }

        [Name("Unit Cost")]
        public decimal? UnitCost { get; set; }

        [Name("UnitCouponAmount")]
        public decimal? UnitCouponAmount { get; set; }

        [Name("UnitDiscountAmount")]
        public decimal UnitDiscountAmount { get; set; }

        [Name("Quantity")]
        public decimal Quantity { get; set; }

        [Name("MSU Flag")]
        public string MsuFlag { get; set; }

        [Name("Coupon Type")]
        public string CouponType { get; set; }

        [Name("Discount Type")]
        public string DiscountType { get; set; }

        [Name("Transaction Type")]
        public string TransactionType { get; set; }

        [Name("Promo Flag")]
        public string PromoFlag { get; set; }

        [Name("Promo Number")]
        public string PromoNumber { get; set; }

    }
}
