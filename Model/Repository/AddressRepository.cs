using supermercadosq.Domain;
using supermercadosq.Model.Request;
using supermercadosq.Model.Connection;
using supermercadosq.Model.Response;

namespace supermercadosq.Model.Repository{
    public class AddressRepository
    {
        public Address CreateAddress(AddressRequest addressRequest, DatabaseConnection context)
        {
        var address = new Address
        {
            Road = addressRequest.Road,
            Number = addressRequest.Number,
            District = addressRequest.District,
            City = addressRequest.City,
            State = addressRequest.State,
            User = addressRequest.User,
            CreationDate = DateTime.UtcNow,
            UpdateDate = DateTime.UtcNow,
            DeletionDate = null
        };
        context.Addresses.Add(address);
        context.SaveChanges();

        return address;
        }
        
        public Address UpdateAddress(int id, AddressRequest addressRequest, DatabaseConnection context)
        {
            var address = context.Addresses.Where(a => a.Id == id).First();

            address.Road = addressRequest.Road != null ? addressRequest.Road : address.Road;
            address.Number = addressRequest.Number != null ? addressRequest.Number : address.Number;
            address.District = addressRequest.District != null ? addressRequest.District : address.District; 
            address.City = addressRequest.City != null ? addressRequest.City : address.City;
            address.State = addressRequest.State != null ? addressRequest.State : address.State;
            address.UpdateDate = DateTime.UtcNow;

        context.SaveChanges();

        return address;
        }

        public Address DeleteAddress(int id, DatabaseConnection context)
        {
            var address = context.Addresses.Where(a => a.Id == id).First();

        context.Addresses.Remove(address);
        context.SaveChanges();

        return address;
        }

        public List<AddressResponse> GetAllAddress(DatabaseConnection context)
        {
            List<Address> addresses = context.Addresses.ToList();
            List<AddressResponse> responses = new List<AddressResponse>();
            foreach(Address address in addresses)
            {
                var response = new AddressResponse
                (
                    address.Road,
                    address.Number,
                    address.District,
                    address.City,
                    address.State
                );
                responses.Add(response);
            }
            return responses;
        }

        public AddressResponse GetAddressSingle(int id, DatabaseConnection context)
        {
            var address = context.Addresses.Where(a => a.Id == id).First();
            
                var response = new AddressResponse
                (
                    address.Road,
                    address.Number,
                    address.District,
                    address.City,
                    address.State
                );
            
            return response;
        }
    }
}