
using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services;


public interface IUsersService
{
	public Task<List<User>> GetAllUsers();
}

public class UsersService : IUsersService
{
	public Task<List<User>> GetAllUsers()
	{
		return Task.FromResult(new List<User>());
	}
    
}