using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace Financeiro.API.OperationFilters
{
    public class AuthResponsesOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var authAttributes = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
                .Union(context.MethodInfo.GetCustomAttributes(true))
                .OfType<AuthorizeAttribute>();

            if (authAttributes.Any())
                operation.Responses.Add("401", new OpenApiResponse { Description = "Unauthorized" });
        }
    }
}
