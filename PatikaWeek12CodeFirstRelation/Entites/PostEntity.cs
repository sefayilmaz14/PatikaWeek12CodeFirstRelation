namespace PatikaWeek12CodeFirstRelation.Entites
{
    public class PostEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }

        //Relotional Propetry
        public UserEntity User { get; set; }
    }
}
