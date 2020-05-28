using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConfigurationHelp
{
    /// <summary>
    /// 複數
    /// </summary>
    public class ZsElementCollection : ConfigurationElementCollection
    {
        public YElement this[int index]
        {
            get { return (YElement)this.BaseGet(index); }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new YElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((YElement)element).y1;
        }
    }
}
