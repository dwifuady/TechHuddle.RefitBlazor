using System.Text.Json.Serialization;

namespace TechHuddle.RefitBlazor;

public class User
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("twitter_username")]
    public string TwitterUsername { get; set; }

    [JsonPropertyName("github_username")]
    public string GithubUsername { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("website_url")]
    public string WebsiteUrl { get; set; }

    [JsonPropertyName("profile_image")]
    public string ProfileImage { get; set; }

    [JsonPropertyName("profile_image_90")]
    public string ProfileImage90 { get; set; }
}
