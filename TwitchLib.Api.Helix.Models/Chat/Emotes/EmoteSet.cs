﻿using Newtonsoft.Json;

namespace TwitchLib.Api.Helix.Models.Chat.Emotes
{
    public class EmoteSet : Emote
    {
        [JsonProperty("emote_type")]
        public string EmoteType { get; protected set; }
        [JsonProperty("emote_set_id")]
        public string EmoteSetId { get; protected set; }
        [JsonProperty("owner_id")]
        public string OwnerId { get; protected set; }
    }
}