namespace supermercadosq.Domain{
    public abstract class Entity{
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeletionDate { get; set; }
    }
}