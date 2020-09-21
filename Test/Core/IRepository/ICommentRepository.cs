using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Core.Dto;
using Test.Core.Model;

namespace Test.Core.IRepository
{
    public interface ICommentRepository
    {
        Task<CommentModel> CreateCommentAsync(CommentCreateDto dto);
        Task<ICollection<CommentModel>> GetAllCommentsAsync();
        Task<CommentModel> GetCommentByIdAsync(int id);
        Task<CommentModel> PatchCommentAsync(CommentPatchDto dto);
        Task<bool> DeleteCommentAsync(int id);
    }
}
