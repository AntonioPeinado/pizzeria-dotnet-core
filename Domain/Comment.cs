using System;

namespace API.Domain
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
    }
}