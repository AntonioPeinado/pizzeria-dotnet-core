using System;
using API.Domain;
using API.DTO;

namespace API.Application
{
    public class CommentMapper : ICommentMapper
    {
        private readonly IUserService _userService;
        private readonly IUserMapper _userMapper;

        public CommentMapper(IUserService userService, IUserMapper userMapper)
        {
            _userService = userService;
            _userMapper = userMapper;
        }
        public Comment ToComment(CreateCommentDTO dto)
        {
            return new Comment()
            {
                Id = Guid.NewGuid(),
                Text = dto.Text,
                Score = dto.Score,
                Date = DateTime.Now,
                User = _userService.FindById(dto.UserId)
            };
        }
        public CommentDetailDTO ToCommentDetail(Comment comment)
        {
            return new CommentDetailDTO()
            {
                Id = comment.Id,
                Text = comment.Text,
                Date = comment.Date,
                Score = comment.Score,
                User = _userMapper.ToUserDetail(comment.User)
            };
        }
    }
}