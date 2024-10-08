namespace PatikaWeek12CodeFirstRelation.Entites
{
    public class UserEntity : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }

        //Relotional Propetry
        public List<PostEntity> Posts { get; set; }



    }
}
