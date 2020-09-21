using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Core.Dto;
using Test.Core.IRepository;
using Test.Core.Model;

namespace Test.Core.Repository
{
    public class PostRepository : IPostRepository
    {
        public async Task<PostReadDto> CreatePostAsync(PostCreateDto dto)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ICollection<PostReadDto>> GetAllPostsAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<ICollection<PostReadDto>> SearchPostsByKeyAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PostReadDto> GetPostByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PostReadDto> PatchPostAsync(PostPatchDto dto)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> DeletePostAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
