using System;

namespace API.DTO
{
    public class CommentDetailDTO
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
        public UserDetailDTO User { get; set; }
    }
}