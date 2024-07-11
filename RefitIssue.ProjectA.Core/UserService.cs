using Refit;
using RefitIssue.ProjectB.Client;

namespace RefitIssue.ProjectA.Core
{
    public class UserService
    {
        private IGitHubApi gitHubApi = RestService.For<IGitHubApi>("https://api.github.com");

        public async Task<User> GetUser()
        {
            var response = await gitHubApi.GetUser("octocat");

            //On Refit 7.1.2, calling 'response.IsSuccessStatusCode' throws an Exception:
            //System.MissingMethodException: Method not found: 'Boolean Refit.IApiResponse`1.get_IsSuccessStatusCode()'.
            if (! response.IsSuccessStatusCode)
            {
                return null;
            }

            return response.Content;
        }

    }
}
