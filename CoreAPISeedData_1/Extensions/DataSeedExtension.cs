using CoreAPISeedData_1.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreAPISeedData_1.Extensions
{
    public static class DataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder) 
        {
            //Bu yaptığımız yöntemde Primary Key identity'si tetiklenmez... Dolayısıyla ID'yi burada elle vermeliyiz...

            Category c = new()
            {
                ID = 1,
                CategoryName = "Tatlılar",
                Description = "Test verisi 13"
            };
            modelBuilder.Entity<Category>().HasData(c);
        }
    }
}
