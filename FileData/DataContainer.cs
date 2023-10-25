using Domain.Models;

namespace a;

public class DataContainer
{
    public ICollection<User> Users { get; set; }
    public ICollection<Todo> Todos { get; set; }
}