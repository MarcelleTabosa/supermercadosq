using Microsoft.AspNetCore.Mvc;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Repository;
using supermercadosq.Model.Response;

namespace supermercadosq.Endpoint
{
    public class AddressGetSingle
    {
        public static string Template => "/address/{id}";
        public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute] int id, DatabaseConnection context)
        {
            var addressRepository = new AddressRepository();
            AddressResponse addressResponse = addressRepository.GetAddressSingle(id, context);
            return Results.Ok(addressResponse);
        }
    }
}