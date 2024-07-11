using Refit;

namespace RefitIssue.ProjectB.Client
{
    public interface IGitHubApi
    {
        [Get("/users/{user}")]
        Task<IApiResponse<User>> GetUser(string user);
    }

    public class User
    {
        public int Id { get; set; }
    }
}
