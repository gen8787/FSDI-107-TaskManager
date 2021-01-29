namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool Important { get; set; }

        public string StartDate { get; set; }

        public string DueDate { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }

        public string User { get; set; }

        public Task() //constructor - access level and class name. no return type
        {

        }

    }
}