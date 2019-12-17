using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Daisy.DataExtract.DataModel
{
    class Store
    {
        [Name("Store Number")]
        public int StoreNumber { get; set; }

        [Name("Store Type ID")]
        public int StoreTypeId { get; set; }

        [Name("Store Type Description")]
        public string StoreTypeDescription { get; set; }

        [Name("Store Name")]
        public string StoreName { get; set; }

        [Name("Address")]
        public string Address { get; set; }

        [Name("City")]
        public string City { get; set; }

        [Name("Province State")]
        public string ProvinceState { get; set; }

        [Name("Postal Zip Code")]
        public int PostalZipCode { get; set; }

        [Name("Store Hierarchy Level 1 ID")]
        public int StoreHierarchyLevel1Id { get; set; }

        [Name("Store Hierarchy Level 1 Name")]
        public string StoreHierarchyLevel1Name { get; set; }

        [Name("Store Hierarchy Level 2 ID")]
        public int StoreHierarchyLevel2Id { get; set; }

        [Name("Store Hierarchy Level 2 Name")]
        public string StoreHierarchyLevel2Name { get; set; }

        [Name("Date Opened")]
        public DateTime DateOpened { get; set; }

        [Name("Date Closed")]
        public DateTime DateClosed { get; set; }

        [Name("Price Zone ID")]
        public int PriceZoneId { get; set; }

        [Name("Price Zone Description")]
        public string PriceZoneDescription { get; set; }

        [Name("Ad Zone ID")]
        public int AdZoneId { get; set; }

        [Name("Ad Zone Description")]
        public string AdZoneDescription { get; set; }

        [Name("Status ID")]
        public int StatusId { get; set; }

        [Name("Status Description")]
        public string StatusDescription { get; set; }


    }
}
