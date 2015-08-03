
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuccessWPF
{
    public class Configuration : ConfigurationSection
    {
       [ConfigurationProperty("Major", IsRequired = true, DefaultValue=0)]
        public int Major
        {
            get
            {
                return (int)this["Major"];
            }
            set
            {
                this["Major"] = value;
            }
        }

        [ConfigurationProperty("Minor", IsRequired = true, DefaultValue = 0)]
        public int Minor
        {
            get
            {
                return (int)this["Minor"];
            }
            set
            {
                this["Minor"] = value;
            }
        }

        [ConfigurationProperty("Revision", IsRequired = true, DefaultValue = 0)]
        public int Revision
        {
            get
            {
                return (int)this["Revision"];
            }
            set
            {
                this["Revision"] = value;
            }
        }

        [ConfigurationProperty("Build", IsRequired = true, DefaultValue = 0)]
        public int Build
        {
            get
            {
                return (int)this["Build"];
            }
            set
            {
                this["Build"] = value;
            }
        }
        
    }

}
