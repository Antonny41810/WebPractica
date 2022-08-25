using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPractica.Models;

namespace WebPractica.Controllers
{
    public class CuentasController : Controller
    {
        private readonly UserManager<IdentityUser> _userMananger;
        private readonly SignInManager<IdentityUser> _singInManager;

        public CuentasController(UserManager<IdentityUser> userMananger, SignInManager<IdentityUser> signInManager)
        {
            _userMananger = userMananger;
            _singInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Registro()
        {
            RegistroUsuarios RuVista = new RegistroUsuarios();
            return View(RuVista);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Registro(RegistroUsuarios ru)
        {
            // Verifico si el modelo es valido
            if (ModelState.IsValid)
            {
                // Creo una variable
                var usuario = new AppUsuario
                {
                    UserName = ru.Email,
                    Email = ru.Email,
                    Documento = ru.Documento,
                    Nombre = ru.Nombre
                };
                // Recibe dos parametros,la variable usuario y el password
                var resultado = await _userMananger.CreateAsync(usuario, ru.Password);
                // Verifica que todo salió bien
                if (resultado.Succeeded)
                {
                    // Se autenticarse
                    await _singInManager.SignInAsync(usuario, isPersistent: false);
                    // Vuelvaala pagina de inicio
                    return RedirectToAction("Index", "Home");
                }
                ValidarErrores(resultado);
            }
            // Si el modelo no es valido retornaala vista donde estaba
            return View(ru);
        }
        // Manejador de errores

        private void ValidarErrores(IdentityResult resultado)
        {
            foreach (var error in resultado.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);

            }
        }

        [HttpGet]

        public IActionResult Acceso()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Acceso(LoginUsuarios lu)
        {
            if (ModelState.IsValid)
            {
                var resultado = await _singInManager.PasswordSignInAsync(lu.Email, lu.Password, lu.Rememberme, lockoutOnFailure: false);
                if (resultado.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Ingreso invalido");
                    return View(lu);
                }
            }
            return View(lu);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> SalirAplicacion()
        {
            await _singInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

    }
}

