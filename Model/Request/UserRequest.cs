using supermercadosq.Entities.Enum;

namespace supermercadosq.Model.Request
{
    public record UserRequest(
    string Name, 
    string SocialName, 
    string CpfCnpj, 
    string Email, 
    string Password, 
    Level Level, 
    Boolean Active, 
    string PhoneNumber
    );
}