using b3.PhamThaiSon.Models;
namespace b3.PhamThaiSon.Models.Data
{
    public class SeedData
    {
        //Gia Lap du lieu ban dau cho database
        public static List<category> categories = new List<category>
        {
            new category(){id=1,Name="Category 1",Description="Description 1" },
            new category(){id=2,Name="Category 2",Description="Description 2"},
            new category(){id=3,Name="Category 3",Description="Description 3"},

        };
       // internal static string? _categories;
    }
}
