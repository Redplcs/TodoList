namespace Redplcs.TodoList.Core.Entities;

public static class EntityCollectionExtensions
{
	public static Entity Create(this IEntityCollection collection)
	{
		return collection.Create(_ => { });
	}
}
