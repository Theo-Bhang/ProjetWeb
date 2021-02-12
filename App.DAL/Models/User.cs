using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.DAL
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string Mdp { get; set; }
        public string AssignedTask { get; set; }

    }



}
