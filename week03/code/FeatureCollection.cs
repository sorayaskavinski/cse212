using System.Text.Json.Serialization;
using System.Collections.Generic;

public class FeatureCollection
{
     // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    
       public List<Feature> Features { get; set; }
}

public class Feature
{
    public Properties Properties { get; set; }
}

public class Properties
{
    [JsonPropertyName("place")]
    public string Place { get; set; }

    [JsonPropertyName("mag")]
    public double? Magnitude { get; set; }
}