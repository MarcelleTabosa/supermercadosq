using supermercadosq.Model.Connection;
using supermercadosq.Model.Repository;
using supermercadosq.Model.Response;

namespace supermercadosq.Endpoint
{
    public class AddressGet
    {
        public static string Template => "/address";
        public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(DatabaseConnection context)
        {
            var addressRepository = new AddressRepository();
            List<AddressResponse> addresses = addressRepository.GetAllAddress(context);
            return Results.Ok(addresses);
        }
    }
}