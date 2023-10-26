using Domain.DTOs;
using Domain.Models;

namespace Application.LogicInterfaces;

public class IUserLogic
{
    public Task<User> CreateAsync(UserCreationDto dto);
    public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters);
}
}