namespace BapApi.Models
{
    public class StoreApp
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public double Rating{ get; set; }
       public int People{ get; set; }
       public string Category{ get; set; }
       public string Date{ get; set; }
       public string Price{ get; set; }
    }

    public class StoreAppDTO
    {
       public int Id { get; set; }
       public string Name { get; set; }

    }

}