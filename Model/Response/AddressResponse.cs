namespace supermercadosq.Model.Response
{
    public record AddressResponse(
    string Road, 
    string Number, 
    string District, 
    string City,
    string State
    );
}