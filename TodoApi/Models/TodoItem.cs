namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        //This functions as the primary key in a database.

        public string? Name { get; set; }

        public bool IsComplete { get; set; }
    }
}
