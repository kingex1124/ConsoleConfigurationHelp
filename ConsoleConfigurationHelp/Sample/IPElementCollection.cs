using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConfigurationHelp.Sample
{
    public class IPElementCollection : ConfigurationElementCollection
    {
        public IPElement this[int index]
        {
            get { return (IPElement)this.BaseGet(index); }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new IPElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((IPElement)element).Key;
        }
    }
}
