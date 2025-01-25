using System.Text.Json.Serialization;
using System.Collections.Generic;

public class FeatureCollection
{
     // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("metadata")]
    public Metadata Metadata { get; set; }

    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }
}

public class Metadata
{
    [JsonPropertyName("generated")]
    public long Generated { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("api")]
    public string Api { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }
}

public class Feature
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("properties")]
    public Properties Properties { get; set; }

    [JsonPropertyName("geometry")]
    public Geometry Geometry { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

public class Properties
{
    [JsonPropertyName("mag")]
    public double? Magnitude { get; set; }

    [JsonPropertyName("place")]
    public string Place { get; set; }

    [JsonPropertyName("time")]
    public long Time { get; set; }

    [JsonPropertyName("updated")]
    public long Updated { get; set; }

    [JsonPropertyName("tz")]
    public int? TimeZone { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("detail")]
    public string Detail { get; set; }
}

public class Geometry
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("coordinates")]
    public List<double> Coordinates { get; set; }
}
