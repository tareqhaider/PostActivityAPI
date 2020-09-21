using System;
using System.ComponentModel.DataAnnotations;
using Test.Core.Model;

namespace Test.Core.Dto
{
    public class CommentCreateDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Description { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        [Required]
        public int UserId { get; set; }
    }

    public class CommentReadDto
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public string UserName { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }
    }

    public class CommentPatchDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Description { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public int Likes { get; set; }

        public int Dislikes { get; set; }
    }
}
