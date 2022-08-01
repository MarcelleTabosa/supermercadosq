using Microsoft.AspNetCore.Mvc;
using supermercadosq.Domain;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Repository;
using supermercadosq.Model.Request;

namespace supermercadosq.Endpoint
{
    public class AddressPut
    {
        public static string Template => "/address/{id}";
        public static string[] Methods => new string[] { HttpMethod.Put.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, AddressRequest addressRequest, DatabaseConnection context)
        {
            var addressRepository = new AddressRepository();
            var address = addressRepository.UpdateAddress(id, addressRequest, context);

            return Results.StatusCode(200);
        }
    }
}