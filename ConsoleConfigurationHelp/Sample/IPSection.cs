using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConfigurationHelp.Sample
{
    public class IPSection : ConfigurationSection
    {
        /// <summary>
        /// DefaultValue: 設定屬性是否預設 string bool
        /// IsRequired: 是否必填
        /// </summary>
        [ConfigurationProperty("SectionKey", DefaultValue = "NoValue", IsRequired = false)]
        public string SectionKey
        {
            get
            {
                return this["SectionKey"].ToString();
            }
            set
            {
                this["SectionKey"] = value;
            }
        }

        /// <summary>
        /// 使用ElementCollection 在一個Section中，可以有多個元素
        /// </summary>
        [ConfigurationProperty("IPGroup"), ConfigurationCollection(typeof(IPElement))]
        public IPElementCollection IPGroup
        {
            get { return this["IPGroup"] as IPElementCollection; }
            set { this["IPGroup"] = value; }
        }
    }
}
