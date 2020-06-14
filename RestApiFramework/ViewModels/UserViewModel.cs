using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiFramework.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        public Int64 Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Int32 AuthLevelId { get; set; }
    }
}
