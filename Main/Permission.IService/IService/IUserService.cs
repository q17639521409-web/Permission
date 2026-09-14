using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.IService.IService
{
    public interface IUserService
    {
        public List<userModel> GetUsers();
        public bool Delete();
        public bool Edit(List<string> users);


    }
}
