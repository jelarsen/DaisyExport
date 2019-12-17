using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Daisy.DataExtract.DataModel
{
    class FileControl
    {
        [Name("Date")]
        public DateTime Date { get; set; }

        [Name("File Name")]
        public string FileName { get; set; }

        [Name("Record Count")]
        public int RecordCount { get; set; }

        [Name("Sum Field Name")]
        public string SumFieldName { get; set; }

        [Name("Sum Value")]
        public int SumValue { get; set; }
    }
}
