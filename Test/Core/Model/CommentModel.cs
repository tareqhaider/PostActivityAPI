using System;

namespace Test.Core.Model
{
    public class CommentModel : BaseModel
    {
        public int? Likes { get; set; }
        public int? Dislikes { get; set; }
        public UserModel User { get; set; }

    }
}
