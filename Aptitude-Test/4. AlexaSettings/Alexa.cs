using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaSettings
{
    public class Alexa
    {
        Configurations alexaConfigurations;        

        public Alexa()
        {
            alexaConfigurations = new Configurations();            
        }
        public string Talk()
        {
            return alexaConfigurations.GreetingMessage.Replace("{OwnerName}",alexaConfigurations.OwnerName);           
        }

        public void Configure(Action<Configurations> obj)
        {
            obj(alexaConfigurations);
        }
    }


}
