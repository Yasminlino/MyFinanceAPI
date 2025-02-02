using Microsoft.AspNetCore.Identity;
using System;

namespace MyFinanceAPI.Domain.Entities
{
    // Herdando de IdentityUser para integração com o ASP.NET Core Identity
    public class Usuario : IdentityUser<int> // 'int' é o tipo da chave primária
    {
        // Propriedades adicionais para o usuário
        public string NomeUsuario { get; set; }
        public bool StatusAtivo { get; set; }
        public string Role {get; set;}
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public Usuario()
        {
        }

        // Construtor da classe Usuario
        public Usuario(string userName,
               string senha,
               string nomeUsuario,
               string role,
               bool statusAtivo,
               DateTime criadoEm,
               DateTime atualizadoEm)
        {
            this.UserName = userName;      // O login será o nome de usuário
            this.Email = userName;         // O email será usado como login (caso seja necessário)
            this.NomeUsuario = nomeUsuario;
            this.Role = role; 
            this.StatusAtivo = statusAtivo;
            this.CriadoEm = criadoEm;
            this.AtualizadoEm = atualizadoEm;

            // Aqui usamos o método SetSenhaHash para configurar a senha de forma segura
            SetSenhaHash(senha);
        }


        // Método para configurar o hash da senha
        public void SetSenhaHash(string senha)
        {
            var passwordHasher = new PasswordHasher<Usuario>();
            this.PasswordHash = passwordHasher.HashPassword(this, senha);
        }
    }
}
