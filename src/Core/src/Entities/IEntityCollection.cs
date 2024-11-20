namespace Redplcs.TodoList.Core.Entities;

public interface IEntityCollection : IList<Entity>
{
	Entity Create(Action<Entity> configure);
}
