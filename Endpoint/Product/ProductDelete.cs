using Microsoft.AspNetCore.Mvc;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Repository;

namespace supermercadosq.Endpoint
{
    public class ProductDelete
    {
        public static string Template => "/product/{id}";
        public static string[] Methods => new string[] { HttpMethod.Delete.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, DatabaseConnection context)
        {
            var productRepository = new ProductRepository();
            var product = productRepository.DeleteProduct(id,  context);

            return Results.StatusCode(200);
        }
    }
}