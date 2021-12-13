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

        //public IActionResult Cadastrar(IFormCollection form)
        //{
             
        //}
    }
}
