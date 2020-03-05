using API.DTO;
using API.Infraestructure;

namespace API.Application
{
    public class CommentService : BaseService, ICommentService
    {
        private readonly PizzeriaContext _context;
        private readonly IPizzaService _pizzaService;

        private readonly ICommentMapper _commentMapper;
        public CommentService(PizzeriaContext context, IPizzaService pizzaService, ICommentMapper commentMapper) : base(context)
        {
            _context = context;
            _commentMapper = commentMapper;
            _pizzaService = pizzaService;
        }
        public CommentDetailDTO Create(CreateCommentDTO dto)
        {
            var comment = _commentMapper.ToComment(dto);
            _pizzaService.AddComment(dto.PizzaId, comment);
            _context.Comment.Add(comment);
            _context.SaveChanges();
            return _commentMapper.ToCommentDetail(comment);
        }
    }
}