using System.Collections.Generic;
using System.Web.Services;

namespace SoapServiceApplicatition1
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public List<string> CreateGroceryList()
        {
            List<string> myList = new List<string>();
            myList.Add("Pan");
            myList.Add("Leche");
            myList.Add("Manzanas");
            myList.Add("carne");
            myList.Add("Pollo");
            myList.Add("huevos");
            myList.Add("Arroz");

            return myList;
        }
    }
}

