using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConfigurationHelp
{
    public class XSection : ConfigurationSection
    {
        /// <summary>
        /// DefaultValue: 設定屬性是否預設 string bool
        /// IsRequired: 是否必填
        /// </summary>
        [ConfigurationProperty("XKey", DefaultValue = "NoValue", IsRequired = false)]
        public string XKey
        {
            get
            {
                return this["XKey"].ToString();
            }
            set
            {
                this["XKey"] = value;
            }
        }

        /// <summary>
        /// 使用Element 一個Section中，只能有一個元素
        /// </summary>
        [ConfigurationProperty("Y")]
        public YElement y
        {
            get
            {
                return (YElement)this["Y"];
            }
            set
            {
                this["Y"] = value;
            }
        }

        /// <summary>
        /// 使用ElementCollection 在一個Section中，可以有多個元素
        /// </summary>
        [ConfigurationProperty("Zs"),ConfigurationCollection(typeof(YElement))]
        public ZsElementCollection zs
        {
            get { return this["Zs"] as ZsElementCollection; }
            set { this["Zs"] = value; }
        }

    }
}
