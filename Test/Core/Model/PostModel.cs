using System.Collections.Generic;
using System.Xml;

namespace Test.Core.Model
{
    public class PostModel : BaseModel
    {
        public ICollection<CommentModel> Comments { get; set; }
        public UserModel User { get; set; }
    }


}
