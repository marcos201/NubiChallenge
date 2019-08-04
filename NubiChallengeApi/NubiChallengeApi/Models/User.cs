using Newtonsoft.Json;
using NubiChallengeApi.Core.Shared;
using System;

namespace NubiChallengeApi.Models
{
    public class User : BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        internal User() { /* Required by EF */ }

        [JsonConstructor]
        public User(Guid id, string nombre, string apellido, string email, string password)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
            Created = DateTime.Now;
        }
    }
}
