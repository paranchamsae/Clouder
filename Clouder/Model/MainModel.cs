using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Clouder.Model
{
    class MainModel : ClouderUser
    {
        public int num = 0;

        public ClouderUser user = new ClouderUser();
        
    }

    internal class ClouderUser
    {
        public int id;
        public string name;
        public string email;
        public string password;

    }
}
