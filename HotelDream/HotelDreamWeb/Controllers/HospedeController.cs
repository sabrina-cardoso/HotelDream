using HotelDreamLib.Dao;
using HotelDreamLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelDreamWeb.Controllers
{
    public class HospedeController : Controller
    {
        LoginModel login = new LoginModel();
        HospedeModel hospede = new HospedeModel();
        UsuarioModel usuario = new UsuarioModel();

        LoginDao loginDao = new LoginDao();
        HospedeDao hospedeDao = new HospedeDao();
        UsuarioDao usuarioDao = new UsuarioDao();


        // GET: Hospede
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (Session["ErroLogin"] != null)
                ViewBag.erroLogin = Session["ErroLogin"].ToString();

            if(Session["Autorizado"] != null)
                ViewBag.usuario = Session["Autorizado"].ToString();

            return View();
        }

        [HttpPost]
        public void ChecarLogin()
        {           
            login.Usuario = Request["Usuario"];
            login.Senha = Request["Senha"];

            if (loginDao.GetLogin(login))
            {
                Session["Autorizado"] = login.Usuario;
                Session.Remove("ErroLogin");
                Response.Redirect("/Inicio/Index");
            }
            else
            {
                Session["ErroLogin"] = "Senha ou Usuário inválido.";
                Response.Redirect("/Hospede/Login");
            }
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public void ChecarCadastrar()
        {
            usuario.Usuario = Request["Usuario"];
            usuario.Senha = Request["Senha"];
            usuario.Status = 1;
            usuario.Nivel = 3;
            usuarioDao.SetUsuario(usuario);
            usuario.Id = int.Parse(usuarioDao.GetIdUsuario(usuario.Usuario));

            hospede.Id = usuario.Id;
            hospede.Nome = Request["Nome"];
            hospede.CPF = Request["Cpf"];
            hospede.RG = Request["Rg"];
            hospede.DataNasc = Convert.ToDateTime(Request["DataNasc"]);
            hospede.Telefone = Request["Telefone"];
            hospede.Email = Request["Email"];
            hospedeDao.SetHospede(hospede);
        }
    }
}