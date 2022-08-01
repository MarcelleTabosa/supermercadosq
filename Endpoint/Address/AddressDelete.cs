using Microsoft.AspNetCore.Mvc;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Repository;

namespace supermercadosq.Endpoint
{
    public class AddressDelete
    {
        public static string Template => "/address/{id}";
        public static string[] Methods => new string[] { HttpMethod.Delete.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, DatabaseConnection context)
        {
            var addressRepository = new AddressRepository();
            var address = addressRepository.DeleteAddress(id,  context);

            return Results.StatusCode(200);
        }
    }
}