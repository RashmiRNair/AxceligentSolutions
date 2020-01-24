using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaSettings
{
    public class Configurations
    {   
        public Configurations()
        {
            GreetingMessage = "hello, i am Alexa";
            OwnerName = string.Empty;
        }
        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }

    }
}
