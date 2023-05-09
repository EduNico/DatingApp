namespace API.Entities
{
    public class AppUser //Entities es la representacion de las tablas de la base de datos.
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public byte[] PasswordHash {get; set; }
        public byte[] PasswordSalt {get; set; } 
    }
}
