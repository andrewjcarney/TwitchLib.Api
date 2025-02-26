﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.Api.Helix.Models.Moderation.AutomodSettings
{
    public class AutomodSettings
    {
        [JsonProperty(PropertyName = "overall_level")]
        public int? OverallLevel;
        [JsonProperty(PropertyName = "disability")]
        public int? Disability;
        [JsonProperty(PropertyName = "aggression")]
        public int? Aggression;
        [JsonProperty(PropertyName = "sexuality_sex_or_gender")]
        public int? SexualitySexOrGender;
        [JsonProperty(PropertyName = "misogyny")]
        public int? Misogyny;
        [JsonProperty(PropertyName = "bullying")]
        public int? Bullying;
        [JsonProperty(PropertyName = "swearing")]
        public int? Swearing;
        [JsonProperty(PropertyName = "race_ethnicity_or_religion")]
        public int? RaceEthnicityOrReligion;
        [JsonProperty(PropertyName = "sex_based_terms")]
        public int? SexBasedTerms;
    }
}
