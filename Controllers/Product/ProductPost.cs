using supermercadosq.Model.Request;
using supermercadosq.Domain;
using supermercadosq.Data;

namespace supermercadosq.Endpoint
{
    public class ProductPost
    {
        public static string Template => "/product";
        public static string[] Methods => new string[] {HttpMethod.Post.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(ProductRequest productRequest, DatabaseConnection context)
        {
            //var productRepository = new ProductRepository();
            var product = new Product();
            //product = productRepository.CreateProduct(productRequest, context);
            
            return Results.Created($"/Product/{product.Id}", product.Id);
        }
    }
}