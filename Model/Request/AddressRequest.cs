using supermercadosq.Domain.Enum;

namespace supermercadosq.Domain{
    public record AddressRequest (
        string Road,
        string Number,
        string District,
        string City,
        string State,
        int User
    );
}