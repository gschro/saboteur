using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models.AppSettings
{
    public class AwsCognitoConfig
    {
        public string ClientId {get; set;}
        public string ClientSecret { get; set; }
        public string MetaDataAddress { get; set; }
    }
}
