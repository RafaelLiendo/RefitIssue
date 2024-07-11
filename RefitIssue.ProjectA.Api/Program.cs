using RefitIssue.ProjectA.Core;

var userService = new UserService();
var user = await userService.GetUser();

Console.WriteLine("It works until you upgrade Refit to 7.1.2");