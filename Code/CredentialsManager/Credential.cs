using System;
using System.Collections.Generic;
using System.Text;

namespace CredentialsManager
{
    public class Credential
    {
        public Credential() 
        {
        }
        public int Id { get; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Notes { get; set; }
    }
}
