using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;

namespace MongoDBFormats
{
    public class Films
    {
        [BsonId]
        public ObjectId id { get; set; }

        public string name { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)] // tell the C# driver that you want to work in LocalTime, like this
        public DateTime releaseDate { get; set; }

        public int subscription_id { get; set; }

        public double rating { get; set; }

        public string posterFolder { get; set; }

        public string filmFolder { get; set; }

        public int price { get; set; }

        public int length { get; set; }
    }

    public class Serials
    {
        [JsonProperty("sername")]
        public string Sername { get; set; }

        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

        [JsonProperty("posterFolder")]
        public string PosterFolder { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("seasons")]
        public Season[] Seasons { get; set; }
    }

    public class Season
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("sname")]
        public string Sname { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonProperty("series")]
        public Series[] Series { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class Series
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }
    }
}
