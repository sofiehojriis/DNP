using Domain.DTOs;
using Domain.Models;

namespace a;

public class IUserLogic
{
    public Task<User> CreateAsync(UserCreationDto dto);
    public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters);
}
}