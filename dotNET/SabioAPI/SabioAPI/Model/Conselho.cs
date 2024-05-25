using SabioAPI.Model;
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Model
{
    public partial class Conselho
    {
        [JsonProperty("slip")]
        public Slip Slip { get; set; }
    }
}


