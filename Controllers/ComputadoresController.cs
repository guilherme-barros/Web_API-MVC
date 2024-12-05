using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Web_API_MVC.Models;

namespace Web_API_MVC.Controllers
{
    //[Route("[controller]")]
    public class ComputadoresController : Controller
    {
        public string uriBase = "http://localhost:5147/Computadores/";

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                string uriComplementar = "GetAll";
                HttpClient httpClient = new HttpClient();
                //string token = HttpContext.Session.GetString("SessionTokenUsuario");
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await httpClient.GetAsync(uriBase + uriComplementar);
                string serialized = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    List<ComputadorViewModel> listaComputadores = await Task.Run(() => JsonConvert.DeserializeObject<List<ComputadorViewModel>>(serialized));
                    return View(listaComputadores);
                }
                else
                    throw new System.Exception(serialized);
            }
            catch (System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}
