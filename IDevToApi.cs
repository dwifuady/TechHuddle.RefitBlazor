using Refit;

namespace TechHuddle.RefitBlazor;

public interface IDevToApi
{
    [Get("/articles?per_page={count}")]
    Task<List<Article>> GetArticles(int count);

    [Get("/articles?state=fresh&per_page={count}")]
    Task<List<Article>> GetFreshArticles(int count);

    [Get("/articles?state=fresh&per_page={count}&tag={tag}")]
    Task<List<Article>> GetArticlesByTag(int count, string tag);
}
