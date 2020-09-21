using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test.Core.Dto
{
    public class PostCreateDto
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

    public class PostReadDto
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public string UserName { get; set; }

        public ICollection<CommentReadDto> Comments { get; set; }
    }

    public class PostPatchDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Description { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
