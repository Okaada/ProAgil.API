namespace ProAgil.API.Model
{
    public class Event
    {
       public int EventId { get; set; }
       public string Locale { get; set; } 
       public string EventDate { get; set; }
       public string Theme { get; set; }
       public int PeopleQt { get; set; } 
       public string Batch { get; set; }
       public string ImageUrl { get; set;}
    }
}