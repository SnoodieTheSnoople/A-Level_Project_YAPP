using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace YappPrototype1.Login_Forms
{
    class Hash
    {
        private readonly int _cost = 13;
        private readonly char _type = 'b';
        private string salt;

        public Hash()
        {
            salt = BCrypt.Net.BCrypt.GenerateSalt(_cost, _type);
        }

        public string GenerateHash(string plainPassword)
        {
            string hashed = BCrypt.Net.BCrypt.HashPassword(plainPassword, salt);
            return hashed;
        }

        public bool CompareHash(string plainPassword, string hashedPword)
        {
            if (BCrypt.Net.BCrypt.Verify(plainPassword, hashedPword)) return true;
            else return false;
        }
    }
}
