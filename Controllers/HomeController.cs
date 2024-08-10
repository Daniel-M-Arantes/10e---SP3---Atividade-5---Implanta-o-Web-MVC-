using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {

        // instancias do tipo cliente

        Cliente cliente1 = new Cliente(01, " Ana Paula Dentro", "787.559.087-01", "pauladentro@gmail.com", "Biro");
        Cliente cliente2 = new Cliente(02, " Timelo Rego", "925.559.087-35", "timelorego@gmail.com", "Snoopy");
        Cliente cliente3 = new Cliente(03, " Paula Tarjano", "195.559.171-84", "paulatarjano@gmail.com", "Jotá");
        Cliente cliente4 = new Cliente(04, " Tekomo Nakama ", "689.129.087-69", "tekomonacama@gmail.com", "Pretinha");
        Cliente cliente5 = new Cliente(05, " Aliza Cresce ", "379.559.087-48", "alizacresce.com", "Lecy");
        Cliente cliente6 = new Cliente(06, " Tadeu Latraz ", "135.559.087-63", "tadeulatraz@gmail.com", "xuxa");
        Cliente cliente7 = new Cliente(07, " Oscar Alho ", "097.599.087-82", "oscaralho@gmail.com", "Betoven");

        //lista clientes e atribui os cliente.

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        listaClientes.Add(cliente6);
        listaClientes.Add(cliente7);
        




        ViewBag.listaClientes = listaClientes;
        // instancia do tipo fornecedor 


        Fornecedor fornecedor1 = new Fornecedor(01, " Cachorao", "11.158.569/0001-80", "cachorao@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, " Super Cao", "19.158.379/0001-80", "supercao@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, " Dog Super", "14.191.369/0001-80", "dogsuper@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, " Vira Lata ", "15.158.369/0001-80", "viralata@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, " Super Dog", "17.158.3485/0001-80", "superdog@gmail.com");

        //lista de fornecedores e atribui os fornecedores.
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

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
