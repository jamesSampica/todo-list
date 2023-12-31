
namespace TodoList.Routing;

public static class WebApplicationExtensions
{
	public static void RegisterAppRoutes(this WebApplication app)
	{
		var endpointDefinitions = typeof(Program).Assembly
			.GetTypes()
			.Where(t => t.IsAssignableTo(typeof(IRouteDefinition))
			            && !t.IsAbstract && !t.IsInterface)
			.Select(Activator.CreateInstance)
			.Cast<IRouteDefinition>();

		foreach (var endpointDef in endpointDefinitions)
		{
			endpointDef.MapRoutes(app);
		}
	}
}