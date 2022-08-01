using supermercadosq.Model.Request;
using supermercadosq.Model.Connection;
using supermercadosq.Domain;
using supermercadosq.Model.Repository;

namespace supermercadosq.Endpoint
{
    public class AddressPost
    {
        public static string Template => "/address";
        public static string[] Methods => new string[] {HttpMethod.Post.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(AddressRequest addressRequest, DatabaseConnection context)
        {
            var addressRepository = new AddressRepository();
            var address = new Address();
            address = addressRepository.CreateAddress(addressRequest, context);
            
            return Results.Created($"/address/{address.Id}", address.Id);
        }
    }
}