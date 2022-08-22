using Microsoft.AspNetCore.Mvc;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Repository;
using supermercadosq.Model.Response;

namespace supermercadosq.Endpoint
{
    public class ProductGetSingle
    {
        public static string Template => "/product/{id}";
        public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute] int id, DatabaseConnection context)
        {
            var productRepository = new ProductRepository();
            ProductResponse ProductResponse = productRepository.GetProductSingle(id, context);
            return Results.Ok(ProductResponse);
        }
    }
}