﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Moderation.BlockedTerms
{
    public class GetBlockedTermsResponse
    {
        [JsonProperty(PropertyName = "data")]
        public BlockedTerm[] Data { get; protected set; }
        [JsonProperty(PropertyName = "pagination")]
        public Pagination Pagination { get; protected set; }
    }
}
