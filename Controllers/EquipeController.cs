using e_jogos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_jogos.Controllers
{
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();
        public IActionResult Index()
        {
            //VIEW, responsável pela exibição do frontend
            // ViewBag, ajuda a armazenar as informações do backend para serem acessadas no frontend
            
            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            //Criando um objeto equipe a partir do frontend (IFormCollection)
            Equipe nova_equipe = new Equipe();
            nova_equipe.IdEquipe = int.Parse(form["IdEquipe"]);
            nova_equipe.Nome = form["Nome"];
            nova_equipe.Imagem = form["Imagem"];

            //Chamando a função create do objeto passando a nova equipe
            equipeModel.Create(nova_equipe);
            
            ViewBag.Equipes = equipeModel.ReadAll();

            return LocalRedirect("~/Equipe");
        }
    }
}
