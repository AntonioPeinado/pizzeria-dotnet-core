using API.DTO;

namespace API.Application
{
    public interface ICommentService
    {
        CommentDetailDTO Create(CreateCommentDTO dto);
    }
}