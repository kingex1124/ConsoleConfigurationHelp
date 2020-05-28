using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConfigurationHelp
{
    public class YElement : ConfigurationElement
    {
        /// <summary>
        /// 用Y1當Key
        /// DefaultValue: 設定屬性是否預設 string bool
        /// IsRequired: 是否必填
        /// </summary>
        [ConfigurationProperty("Y1", DefaultValue = "value", IsRequired = false)]
        public String y1
        {
            get
            {
                return (String)this["Y1"];
            }
            set
            {
                this["Y1"] = value;
            }
        }

        [ConfigurationProperty("Y2", DefaultValue = "value", IsRequired = false)]
        public String y2
        {
            get
            {
                return (String)this["Y2"];
            }
            set
            {
                this["Y2"] = value;
            }
        }

        [ConfigurationProperty("Y3", DefaultValue = "value", IsRequired = false)]
        public String y3
        {
            get
            {
                return (String)this["Y3"];
            }
            set
            {
                this["Y3"] = value;
            }
        }
    }
}
