namespace API.DTOs
{
    public class UserDto  //this DTO  is use to Return a token whea a user logs in 
    {
        public string Username { get; set; } 

        public string Token { get; set; }
        public string PhotoUrl { get; set; }

    }
}