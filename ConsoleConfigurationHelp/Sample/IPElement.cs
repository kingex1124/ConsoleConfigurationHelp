using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConfigurationHelp.Sample
{
    public class IPElement : ConfigurationElement
    {
        [ConfigurationProperty("Key", DefaultValue = "NoValue", IsRequired = false)]
        public String Key
        {
            get
            {
                return (String)this["Key"];
            }
            set
            {
                this["Key"] = value;
            }
        }

        [ConfigurationProperty("Name", DefaultValue = "NoValue", IsRequired = false)]
        public String Name
        {
            get
            {
                return (String)this["Name"];
            }
            set
            {
                this["Name"] = value;
            }
        }

        [ConfigurationProperty("ConnectionStringA", DefaultValue = "NoValue", IsRequired = false)]
        public String ConnectionStringA
        {
            get
            {
                return (String)this["ConnectionStringA"];
            }
            set
            {
                this["ConnectionStringA"] = value;
            }
        }

        [ConfigurationProperty("ConnectionStringB", DefaultValue = "NoValue", IsRequired = false)]
        public String ConnectionStringB
        {
            get
            {
                return (String)this["ConnectionStringB"];
            }
            set
            {
                this["ConnectionStringB"] = value;
            }
        }

        [ConfigurationProperty("ConnectionStringC", DefaultValue = "NoValue", IsRequired = false)]
        public String ConnectionStringC
        {
            get
            {
                return (String)this["ConnectionStringC"];
            }
            set
            {
                this["ConnectionStringC"] = value;
            }
        }
    }
}
