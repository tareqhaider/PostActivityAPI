using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Core.Dto;
using Test.Core.Model;

namespace Test.Core.IRepository
{
    public interface IPostRepository
    {
        Task<PostReadDto> CreatePostAsync(PostCreateDto dto);
        Task<ICollection<PostReadDto>> GetAllPostsAsync();
        Task<ICollection<PostReadDto>> SearchPostsByKeyAsync(string key);
        Task<PostReadDto> GetPostByIdAsync(int id);
        Task<PostReadDto> PatchPostAsync(PostPatchDto dto);
        Task<bool> DeletePostAsync(int id);
    }
}
