using supermercadosq.Entities.Enum;

public record UserRequestDTO(
    string Name, 
    string SocialName, 
    string CpfCnpj, 
    string Email, 
    string Password, 
    Level Level, 
    Boolean Active, 
    string PhoneNumber
);
