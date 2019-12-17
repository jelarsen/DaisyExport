using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Daisy.DataExtract.DataModel
{
    class Product
    {
        [Name("SKU / UPC_PLU")]
        public int UpcPlu { get; set; }
        [Name("UPC_PLU")]
        public int UPC_PLU { get; set; }
        [Name("Product Hierarchy Level 4 ID")]
        public int ProductHierarchyLevel4Id { get; set; }
        [Name("Product Hierarchy Level 3 ID")]
        public int ProductHierarchyLevel3Id { get; set; }
        [Name("Product Hierarchy Level 2 ID")]
        public int ProductHierarchyLevel2Id { get; set; }
        [Name("Product Hierarchy Level 1 ID")]
        public int ProductHierarchyLevel1Id { get; set; }
        [Name("Long Description")]
        public string LongDescription { get; set; }
        [Name("Short Description")]
        public string ShortDescription { get; set; }
        [Name("Brand")]
        public string Brand { get; set; }
        [Name("Private label Flag")]
        public string PrivatelabelFlag { get; set; }
        [Name("Organic Flag")]
        public string OrganicFlag { get; set; }
        [Name("Package Size")]
        public string PackageSize { get; set; }
        [Name("Retail Size")]
        public string RetailSize { get; set; }
        [Name("Sell by Weight Flag")]
        public string SellbyWeightFlag { get; set; }
        [Name("Item Status ID Code")]
        public int ItemStatusIdCode { get; set; }
        [Name("Item Status Description")]
        public string ItemStatusDescription { get; set; }
    }
}
