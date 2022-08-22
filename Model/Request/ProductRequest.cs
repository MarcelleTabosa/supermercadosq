using supermercadosq.Domain.Enum;

namespace supermercadosq.Model.Request
{
    public record ProductRequest(
    string Name,
    string Ingredient,
    string Image,
    State Status,
    int User
    );
}