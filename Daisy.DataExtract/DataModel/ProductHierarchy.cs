using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Daisy.DataExtract.DataModel
{
    class ProductHierarchy
    {
        [Name("Product Hierarchy Level 1 ID")]
        public int ProductHierarchyLevel1Id { get; set; }

        [Name("Product Hierarchy Level 1 Name")]
        public int ProductHierarchyLevel1Name { get; set; }

        [Name("Product Hierarchy Level 2 ID")]
        public int ProductHierarchyLevel2Id { get; set; }

        [Name("Product Hierarchy Level 2 Name")]
        public int ProductHierarchyLevel2Name { get; set; }

        [Name("Product Hierarchy Level 3 ID")]
        public int ProductHierarchyLevel3Id { get; set; }

        [Name("Product Hierarchy Level 3 Name")]
        public int ProductHierarchyLevel3Name { get; set; }

        [Name("Product Hierarchy Level 4 ID")]
        public int ProductHierarchyLevel4Id { get; set; }

        [Name("Product Hierarchy Level 4 Name")]
        public int ProductHierarchyLevel4Name { get; set; }
    }
}
