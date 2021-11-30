using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DescarteSustentavel.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DescarteSustentavel.Pages
{
    public class IndexModel : PageModel
    {

        private readonly DescarteSustentavelContext _db;

        [BindProperty, Required]
        public string Email { get; set; }
        [BindProperty, Required]
        public string Senha { get; set; }

        [BindProperty]
        public string NomeCadastro { get; set; }
        [BindProperty]
        public string CpfOuCnpjCadastro { get; set; }
        [BindProperty, Required]
        public string EmailCadastro { get; set; }
        [BindProperty, Required]
        public string SenhaCadastro { get; set; }
        [BindProperty]
        public string TipoDeUsuario { get; set; }

        [BindProperty]
        public string EnderecoCadastro { get; set; }

        [BindProperty]
        public string TelefoneCadastro { get; set; }
        

        public string[] TipoDeUsuarios { get; set; }


        [BindProperty, Required]
        public string EmailEsqueceu { get; set; }
        [BindProperty, Required]
        public string SenhaEsqueceu { get; set; }

        public IndexModel(DescarteSustentavelContext db)
        {
            _db = db;
            TipoDeUsuarios = new[] { "Descartador", "Ecoponto" };
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostLogarAsync()
        {
            Debug.WriteLine("email: "+Email);
            Debug.WriteLine("senha: "+Senha);
            var usuario = await _db.Usuario
              .FirstOrDefaultAsync(m => m.Email == Email && m.Senha == Senha);
            if (usuario == null)
            {
                ModelState.AddModelError("CredenciaisErradas", "Login e senha invalidos");
                return Page();
            }

            return Redirect("/SolicitacoesDescarteColeta");

        }
        public async Task<IActionResult> OnPostCadastrarAsync()
        {

            Debug.WriteLine("email: " + EmailCadastro);
            Debug.WriteLine("senha: " + SenhaCadastro);
            Debug.WriteLine("EnderecoCadastro: " + EnderecoCadastro);
            Debug.WriteLine("TipoDeUsuario: " + TipoDeUsuario);
            Debug.WriteLine("TelefoneCadastro: " + TelefoneCadastro);

            var usuario = await _db.Usuario
              .FirstOrDefaultAsync(m => m.Email == EmailCadastro);
            if (usuario != null)
            {
                ModelState.AddModelError("EmailDuplicado", "Este email já existe");
                return Page();
            }

            if (TipoDeUsuario == "Descartador") {
                var usuarioCadastro = new Models.Descartador() {

                        Nome = NomeCadastro,
                        Email = EmailCadastro,
                        Endereco = EnderecoCadastro,
                        Telefone = TelefoneCadastro,
                        Senha = SenhaCadastro,
                        DataDeCadastro = DateTime.Now,
                        QntSolicitacoes = 0
                    };
                try
                {
                    _db.Descartador.Add(usuarioCadastro);
                    await _db.SaveChangesAsync();
                }
                catch (Exception)
                {
                    ModelState.AddModelError("DadosErrados", "Informacoes invalidas");
                    
                }
               
                Debug.WriteLine("Inserido!");
            }
            else
            {
                try
                {
                    var usuarioCadastro = new Models.Ecoponto()
                    {
                        Nome = NomeCadastro,
                        Email = EmailCadastro,
                        Endereco = EnderecoCadastro,
                        Telefone = TelefoneCadastro,
                        Senha = SenhaCadastro,
                        CpfCnpj = CpfOuCnpjCadastro,
                        Tipo = CpfOuCnpjCadastro.Contains("0001") ? "Juridico" : "Fisico"
                    };
                
                    _db.Ecoponto.Add(usuarioCadastro);
                    await _db.SaveChangesAsync();
                }
                catch (Exception)
                {
                    ModelState.AddModelError("DadosErrados", "Informacoes invalidas");

                }
               
                Debug.WriteLine("Inserido!");
            }
            return Redirect("/Index");
        }

        
    }
}
