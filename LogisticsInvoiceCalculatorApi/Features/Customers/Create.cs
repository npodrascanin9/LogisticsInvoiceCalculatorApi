namespace LogisticsInvoiceCalculatorApi.Features.Customers;

public sealed class CreateCustomerEndpoint :
    ICarterModule
{
    public void AddRoutes(
        IEndpointRouteBuilder app)
    {
        app.MapPost("api/customers", async (
            CreateCustomerRequest request) =>
            {
                throw new ArgumentException("In progress");
            })
            .WithName("Create Customer")
            .WithSummary("Create Customer");
    }
}

public class CreateCustomerRequest
{

}

public static class CreateCustomer
{

}
