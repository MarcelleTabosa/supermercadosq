using Flunt.Validations;

namespace supermercadosq.Domain
{
    public class Address : Entity
    {
        public string Road { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Address
        (
            int id, 
            string road, 
            string number, 
            string district, 
            string city, 
            string state
        )
        {
            var contract = new Contract<Address>()
                .IsNotNullOrEmpty(road, "Road")
                .IsNotNullOrEmpty(number, "Number")
                .IsNotNullOrEmpty(district, "District")
                .IsNotNullOrEmpty(city, "City")
                .IsNotNullOrEmpty(state, "State");

            AddNotifications(contract);

            Id = id;
            Road = road;
            Number = number;
            District = district;
            City = city;
            State = state;
        }
    }
}