﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChangeLogWeb.Models
{
    public class PullRequestDTO
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("merged_at")]
        public string MergedAt { get; set; }

        [JsonProperty("merged")]
        public bool Merged { get; set; }

        [JsonProperty("merged_by")]
        public MergedByDTO MergedBy { get; set; }

        [JsonProperty("base")]
        public BaseDTO Base { get; set; }
    }
}
