﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTools.Wrappers
{
    class VirtualDesktopInfo
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
