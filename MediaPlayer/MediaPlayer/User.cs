using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public class User
    {
        public string name { get; set; }
        public User(string username)
        {
            this.name = username;
        }
    }
}
