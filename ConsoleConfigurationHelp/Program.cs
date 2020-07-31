using ConsoleConfigurationHelp.Sample;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleConfigurationHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            // NameValueCollection settings = ConfigurationManager.GetSection("Company.appSettings") as NameValueCollection;
            //NameValueCollection settings = ConfigurationManager.GetSection("Company/appSettings") as NameValueCollection;

            //if (settings != null)
            //{
            //    foreach (string key in settings)
            //    {
            //        Console.WriteLine("{0} : {1}", key, settings[key]);
            //    }
            //}


            XSection xsection = ConfigurationManager.GetSection("XSection") as XSection;

            if (xsection != null)
            {
                Console.WriteLine(xsection.XKey);
                Console.WriteLine(xsection.y.y1);
                Console.WriteLine(xsection.y.y2);
                Console.WriteLine(xsection.y.y3);


                for (int i = 0; i < xsection.zs.Count; i++)
                {
                    Console.WriteLine("{0} : {1}", xsection.zs[i].y1, xsection.zs[i].y2);
                }
            }

            IPSection ipSection = ConfigurationManager.GetSection("IPChangeSection") as IPSection;

            if (ipSection != null)
            {
                for (int i = 0; i < ipSection.IPGroup.Count; i++)
                {
                    Console.WriteLine("{0} : {1} : {2} : {3} : {4}", ipSection.IPGroup[i].Key, ipSection.IPGroup[i].Name, ipSection.IPGroup[i].ConnectionStringA, ipSection.IPGroup[i].ConnectionStringB, ipSection.IPGroup[i].ConnectionStringC);
                }
            }
        }


        /// <summary>
        /// 透過路徑修改config裡面的資料
        /// </summary>
        public void ByPathUpdataConfigData()
        {
            ExeConfigurationFileMap map = new ExeConfigurationFileMap { ExeConfigFilename = "C://Users//011714//Desktop//config//StockGateway//StockGateway.exe.config" };
            var config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            var conn = config.AppSettings.Settings["ESMPConnectionString"].Value;

            config.AppSettings.Settings["ESMPConnectionString"].Value = config.AppSettings.Settings["ESMPConnectionString"].Value + "456";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
