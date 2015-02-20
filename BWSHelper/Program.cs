using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BWSHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            //var folder = new DirectoryInfo(@"D:\ExcelImport3");
            //var elements = new List<XElement>();
            //var destFolder = new DirectoryInfo(@"D:\Projects\CloudWorkstation\Brady Link 360 Desktop\MW4 Desktop\Applications\MW4.ExcelImport\MW4.ExcelImport.App\Properties");

            //foreach (var directory in folder.GetDirectories())
            //{
            //    var languageName = directory.Name;
            //    if(languageName.Length == 2)
            //    {
            //        languageName = languageName.ToLower();
            //    }
            //    else
            //    {
            //        var first = languageName.Substring(0, 2);
            //        var last = languageName.Substring(2, 3);
            //        languageName = string.Concat(first.ToLower(), last);
            //    }

            //    var appDir = new DirectoryInfo(Path.Combine(directory.FullName, "ExcelImport", "MW4.ExcelImport.App"));
            //    var propertyDir = new DirectoryInfo(Path.Combine(appDir.FullName, "Properties"));
            //    var mwApplicationFile = new FileInfo(Path.Combine(appDir.FullName, "MWApplication.xml"));
            //    var resFile = new FileInfo(Path.Combine(propertyDir.FullName, "Resources.resx"));

            //    var locLangToolTip = XElement.Load(mwApplicationFile.FullName);
            //    var element = locLangToolTip.Elements().First().Elements().First();
            //    element.FirstAttribute.Value = languageName;

            //    elements.Add(element);
            //    var fileDest = Path.Combine(destFolder.FullName, string.Concat(Path.GetFileNameWithoutExtension(resFile.Name) + ".", languageName, Path.GetExtension(resFile.Name)));
            //    //resFile.CopyTo(fileDest);
            //}

            var fileName = @"D:\Projects\CloudWorkstation\Brady Link 360 Desktop\MW4 Desktop\Applications\MW4.ExcelImport\MW4.ExcelImport.App\MWApplication.xml";
            var excelFile = XElement.Load(fileName);
            //var toolTip = excelFile.Elements().First(x => x.Name.LocalName == "toolTip");
            //foreach (var element in elements)
            //{
            //    toolTip.Add(element);
            //}

            //excelFile.Save(fileName);

            var newFile = new FileInfo(@"D:\3.xls");

            var sb = new OleDbConnectionStringBuilder();

            var HDR = "; HDR=YES";
            sb.Provider = "Microsoft.Jet.OleDB.4.0";
            sb.Add("Extended Properties", "Excel 8.0;IMEX=1" + HDR);

            sb.DataSource = newFile.FullName;


            System.Data.OleDb.OleDbConnection MyConnection;
            System.Data.DataSet DtSet;
            System.Data.OleDb.OleDbDataAdapter MyCommand;
            MyConnection = new System.Data.OleDb.OleDbConnection(sb.ToString());
            MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Excel Import$]", MyConnection);
            DtSet = new System.Data.DataSet();
            MyCommand.Fill(DtSet);


            var data = DtSet.Tables[0];

            MyConnection.Close();

            var dataResult = new List<Data>();
            foreach (DataRow row in data.Rows)
            {
                var currentRow = new Data();
                currentRow.Language = row.ItemArray[0].ToString();
                currentRow.Title = row.ItemArray[1].ToString();
                currentRow.Description = row.ItemArray[3].ToString();
                currentRow.FullDescription = row.ItemArray[4].ToString();
                currentRow.Features = row.ItemArray[5].ToString();
                currentRow.Category = row.ItemArray[2].ToString();

                var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures); 
                foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
                {
                    if(culture.EnglishName == currentRow.Language)
                    {
                        currentRow.Language = culture.Name;
                    }
                }

                dataResult.Add(currentRow);
            }

            dataResult.RemoveAt(0);

            var title = excelFile.Elements().First(x => x.Name.LocalName == "title");
            var description = excelFile.Elements().First(x => x.Name.LocalName == "description");
            var features = excelFile.Elements().First(x => x.Name.LocalName == "features");
            var fulldescription = excelFile.Elements().First(x => x.Name.LocalName == "fulldescription");
            var category = excelFile.Elements().First(x => x.Name.LocalName == "category");
            var releasenotesfilename = excelFile.Elements().First(x => x.Name.LocalName == "releasenotesfilename");
            var localizations = excelFile.Elements().First(x => x.Name.LocalName == "localizations");
            var helplocalizations = excelFile.Elements().First(x => x.Name.LocalName == "helplocalizations");

            namesp = excelFile.GetDefaultNamespace().NamespaceName;

            foreach (var row in dataResult)
            {
                //AddElement("localization", row.Title, row.Language, title);
                //AddElement("localization", row.Description, row.Language, description);
                //AddElement("localization", row.FullDescription, row.Language, fulldescription);
                //AddElement("localization", row.Category, row.Language, category);
                //AddElement("localization", row.Features, row.Language, features);

            }

            excelFile.Save(fileName);


                
            }
        private static string namesp;

        public static void AddElement(string name, string value, string language, XElement parent)
        {
            XNamespace xmlns = "http://schemas.brady.com/markware/packaging/2013/07/appmanifest.xsd";
            var el = new XElement(xmlns + name);
            el.SetAttributeValue("lang", language);
            
            el.Value = value;
            parent.Add(el);
        }

        }

        public class Data
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string FullDescription { get; set; }
            public string Features { get; set; }
            public string Language { get; set; }
            public string Category { get; set; }
        }
   
}
