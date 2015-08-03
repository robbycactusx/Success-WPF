using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuccessWPF
{
    public class Container
    {

        private Configuration _Config;

        public System.Version Version
        {
            get
            {
                return new System.Version(_Config.Major, _Config.Minor, _Config.Build, _Config.Revision);
            }
        } 

        public Container()
            : this((Configuration)System.Configuration.ConfigurationManager.GetSection("SuccessWPF"))
        {
        }

        public Container(Configuration config)
        {
            if (config == null)
                throw new ConfigurationErrorsException("Could not find section SuccessWPF in app.config");
            
            _Config = config;
        }
        
    }
}
