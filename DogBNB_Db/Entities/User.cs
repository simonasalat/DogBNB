﻿

using System;

namespace DogBNB_Db.Entities
{ 
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }

        public void remove()
        {
            throw new NotImplementedException();
        }
    }
}
