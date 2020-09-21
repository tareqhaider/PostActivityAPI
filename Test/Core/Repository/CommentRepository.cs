using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Core.Dto;
using Test.Core.IRepository;
using Test.Core.Model;

namespace Test.Core.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private CommentRepository()
        {
        }
        

        public async Task<CommentModel> CreateCommentAsync(CommentCreateDto dto)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ICollection<CommentModel>> GetAllCommentsAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<CommentModel> GetCommentByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<CommentModel> PatchCommentAsync(CommentPatchDto dto)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> DeleteCommentAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
