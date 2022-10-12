using System.Text.Json.Serialization;

namespace TechHuddle.RefitBlazor;

public class Article
{
    [JsonPropertyName("type_of")]
    public string TypeOf { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("readable_publish_date")]
    public string ReadablePublishDate { get; set; }

    [JsonPropertyName("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("comments_count")]
    public int CommentsCount { get; set; }

    [JsonPropertyName("public_reactions_count")]
    public int PublicReactionsCount { get; set; }

    [JsonPropertyName("collection_id")]
    public object CollectionId { get; set; }

    [JsonPropertyName("published_timestamp")]
    public DateTime PublishedTimestamp { get; set; }

    [JsonPropertyName("positive_reactions_count")]
    public int PositiveReactionsCount { get; set; }

    [JsonPropertyName("cover_image")]
    public object CoverImage { get; set; }

    [JsonPropertyName("social_image")]
    public string SocialImage { get; set; }

    [JsonPropertyName("canonical_url")]
    public string CanonicalUrl { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("edited_at")]
    public object EditedAt { get; set; }

    [JsonPropertyName("crossposted_at")]
    public object CrosspostedAt { get; set; }

    [JsonPropertyName("published_at")]
    public DateTime PublishedAt { get; set; }

    [JsonPropertyName("last_comment_at")]
    public DateTime LastCommentAt { get; set; }

    [JsonPropertyName("reading_time_minutes")]
    public int ReadingTimeMinutes { get; set; }

    [JsonPropertyName("tag_list")]
    public List<string> TagList { get; set; }

    [JsonPropertyName("tags")]
    public string Tags { get; set; }

    [JsonPropertyName("user")]
    public User User { get; set; }
}
