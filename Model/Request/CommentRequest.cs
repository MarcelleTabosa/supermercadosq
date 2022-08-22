using supermercadosq.Domain.Enum;
using supermercadosq.Domain;

namespace supermercadosq.Model.Request
{
    public record CommentRequest(
        string Message,
        State Status,
        int User,
        int Product
    );
}