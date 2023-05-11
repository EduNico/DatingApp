using Microsoft.EntityFrameworkCore.Internal;

namespace API.Extensions
{
    public  static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime theDateTime)
        {
        
        
        //var today = DateOnly.FromDateTime(DateTime.UtcNow);
        
        var age = DateTime.Today.Year - theDateTime.Year;
        
        if (theDateTime.AddYears(age)>DateTime.Today) age--;
        return age;
        
        
        }



    }
}