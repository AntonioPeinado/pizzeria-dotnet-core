using API.Domain;
using API.DTO;

namespace API.Application
{
    public interface ICommentMapper
    {
        Comment ToComment(CreateCommentDTO dto);
        CommentDetailDTO ToCommentDetail(Comment comment);
    }
}