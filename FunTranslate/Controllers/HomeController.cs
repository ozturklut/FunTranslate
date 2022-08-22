using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FunTranslate.Models;

namespace FunTranslate.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IHttpClientFactory _httpClientFactory;

    public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://api.funtranslations.com/translate/yoda.json?text=Hello");


        if(responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var jsonData = responseMessage.Content.ReadAsStringAsync();
            ViewBag.ResponseMessage = "Başarılı";
        }
        else
        {
            ViewBag.ResponseMessage = "Başarısız";
        }
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

