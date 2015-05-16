using data = Dump.Internship.NoteShare.Data;
using model = Dump.Internship.NoteShare.Models;

namespace Dump.Internship.NoteShare.Mappers
{
    public class UserMapper
    {
        public static model::User Map(data::User user)
        {
            return new model.User
            {
                FullName = user.FullName
            };
        }
    }
}