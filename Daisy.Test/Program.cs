using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Daisy.DataExtract.Infrastructure;
using Daisy.DataExtract.DataModel;

namespace Daisy.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn = new SqlConnection(@"Data source=ax-sandbox\DEV_HQDB;Initial catalog=HQStage;Integrated security=SSPI;");
            var file = AppDomain.CurrentDomain.BaseDirectory + @"\test.csv";
            var startDate = new DateTime(2019, 11, 27);
            var endDate = new DateTime(2019, 12, 03);
            var sql = @"select
                ec.ItemKey [UpcPlu]
                , '' [PriceItemGroupId]
                , '' [PriceItemGroupDescription]
                , 'Cost' [AmountTypeId]
                , 'Cost' [AmountTypeDescription]
                , ec.StoreKey [StoreNumber]
                , '' [PriceZoneId]
                , '' [PriceZoneDescription]
                , CONVERT(CHAR(8), MIN(ec.DateKey), 112) [StartDate]
                , CONVERT(CHAR(8), MAX(ec.DateKey), 112) [EndDate]
                , CAST((ec.CaseCost - ec.CaseAllowance) / ec.Pack as decimal(10,2)) [UnitAmount]
                , '' [UnitOfMeasure]
                from EffectiveCost ec
                join EffectiveVendor ef
                on ec.VendorKey = ef.VendorKey and ec.DateKey = ef.DateKey and ec.ItemKey = ef.ItemKey and ef.StoreKey = ec.StoreKey
                where ec.DateKey >= @start_date and ec.DateKey <= @end_date
                group by ec.ItemKey, ec.StoreKey, ec.CaseCost, ec.CaseAllowance, ec.Pack

                union all

                select
                ep.ItemKey 
                , ''
                , ''
                , rtrim(ep.PriceType)
                , rtrim(ep.PriceType)
                , ep.StoreKey
                , ''
                , ''
                , CONVERT(CHAR(8), MIN(ep.DateKey), 112) [StartDate]
                , CONVERT(CHAR(8), MAX(ep.DateKey), 112) [EndDate]
                , CAST(ep.Price / ep.PriceMultiple as decimal(10,2))
                , '' 
                from EffectivePrice ep
                join EffectiveVendor ef
                on ep.VendorKey = ef.VendorKey and ep.DateKey = ef.DateKey and ep.ItemKey = ef.ItemKey and ef.StoreKey = ep.StoreKey
                where ep.DateKey >= @start_date and ep.DateKey <= @end_date
                group by ep.ItemKey, ep.StoreKey, ep.Price, ep.PriceMultiple, ep.PriceType
                ";
            var fileMaker = new FileMaker<StorePriceCost>();
            fileMaker.Write(file, false, sql, conn, new { start_date = startDate, end_date = endDate});
        }
    }
}
