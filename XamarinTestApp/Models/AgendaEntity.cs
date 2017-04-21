using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json;

namespace XamarinTestApp.Models
{
    public struct AgendaEntity
    {
        [JsonProperty("Agenda")]
        public string Agenda { get; private set; }

        [JsonProperty("Type")]
        public string Type { get; private set; }

        [JsonProperty("Group")]
        public string Group { get; private set; }

    }
}
