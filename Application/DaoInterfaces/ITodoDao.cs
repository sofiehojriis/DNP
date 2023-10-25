using Domain.DTOs;
using Domain.Models;

namespace a;

public interface ITodoDao
{
    Task<Todo> CreateAsync(Todo todo);
    Task<IEnumerable<Todo>> GetAsync(SearchTodoParametersDto searchParameters);
    Task UpdateAsync(Todo todo);
    Task<Todo?> GetByIdAsync(int todoId);
    
    Task DeleteAsync(int id);
}