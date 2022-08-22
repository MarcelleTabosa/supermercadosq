using Microsoft.AspNetCore.Mvc;
using supermercadosq.Domain;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Repository;
using supermercadosq.Model.Request;

namespace supermercadosq.Endpoint
{
    public class ProductPut
    {
        public static string Template => "/product/{id}";
        public static string[] Methods => new string[] { HttpMethod.Put.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, ProductRequest productRequest, DatabaseConnection context)
        {
            var productRepository = new ProductRepository();
            var product = productRepository.UpdateProduct(id, productRequest, context);

            return Results.StatusCode(204);
        }
    }
}