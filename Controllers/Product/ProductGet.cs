using supermercadosq.Data;
using supermercadosq.Model.Response;

namespace supermercadosq.Endpoint
{
    public class ProductGet
    {
        public static string Template => "/product";
        public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(DatabaseConnection context)
        {
            //var productRepository = new ProductRepository();
            //List<ProductResponse> products = productRepository.GetAllProduct(context);
            return Results.Ok();
        }
    }
}