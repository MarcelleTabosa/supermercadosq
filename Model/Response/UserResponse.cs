namespace supermercadosq.Model.Response
{
    public record UserResponse(
    string Name, 
    string SocialName, 
    string CpfCnpj, 
    string Email,
    string PhoneNumber
    );
}