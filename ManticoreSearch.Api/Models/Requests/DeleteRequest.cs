﻿using Newtonsoft.Json;

namespace ManticoreSearch.Api.Models.Requests
{
    public class DeleteRequest
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("cluster", NullValueHandling = NullValueHandling.Ignore)]
        public string? Cluster { get; set; } = null;

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; } = null;

        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public Query? Query { get; set; } = null;

        public DeleteRequest() { }

        public DeleteRequest(string index, string? cluster = null, long id = 0, Query? query = null)
        {
            Index = index;
            Cluster = cluster;
            Id = id;
            Query = query;
        }
    }
}
