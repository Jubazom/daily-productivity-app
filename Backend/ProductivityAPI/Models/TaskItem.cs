namespace ProductivityAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; } // Todo, Doing, Done

        public int Order { get; set; } // posição no kanban

        public DateTime CreatedAt { get; set; }
    }
}