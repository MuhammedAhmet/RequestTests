using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using RequestTests_Data.Context;
using RequestTests_Data.Entities.Cars;
using RequestTests_Data.Services.Test;

namespace RequestTester_Data
{
    public class Program
    {

        static void Main(string[] args)
        {
            #region REGION
            //var Test_Service = new RequestTester_Data.Services.Test.Test_Service();

            //Test_Service.Create(new Entities.Test.Test_Entity()
            //{
            //    Desc = "Desc_Test",
            //    Name = "Name_Test",
            //});

            //var Get = Test_Service.Get();
            #endregion

            #region XLSX to MongoDB Cars Elements Creation

            //var sb = new StringBuilder(); //this is your data
            //var List = new List<Cars_Entity>();

            ////xlsx to Csv
            //using (ExcelPackage xlPackage = new ExcelPackage(new FileInfo(@"C:\Users\asus\Desktop\merc.xlsx")))
            //{

            //    ExcelPackage.LicenseContext = LicenseContext.Commercial;
            //    var myWorksheet = xlPackage.Workbook.Worksheets.First(); //select sheet here
            //    var totalRows = myWorksheet.Dimension.End.Row;
            //    var totalColumns = myWorksheet.Dimension.End.Column;


            //    for (int rowNum = 1; rowNum <= totalRows; rowNum++) //select starting row here
            //    {
            //        var row = myWorksheet.Cells[rowNum, 1, rowNum, totalColumns].Select(c => c.Value == null ? string.Empty : c.Value.ToString());

            //        var heyyo = row.ToArray();

            //        List.Add(new Cars_Entity()
            //        {
            //            Year = heyyo[0],
            //            Price = heyyo[1],
            //            Transmission = heyyo[2],
            //            MileAge = heyyo[3],
            //            Tax = heyyo[4],
            //            Mpg = heyyo[5],
            //            EngineSize = heyyo[6]

            //        });

            //    }

            //}

            //var service = new RequestTester_Data.Services.Cars.Cars_Service();

            //service.CreateMany(List);

            #endregion

            //var Serv = new Test_Service();

            //var a = Serv.Get();


            Console.ReadLine();
        }
    }
}
