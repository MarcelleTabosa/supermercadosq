using Flunt.Notifications;
using Flunt.Validations;

namespace supermercadosq.Domain
{
    public abstract class Entity : Notifiable<Notification>
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeletionDate { get; set; }
    }
}