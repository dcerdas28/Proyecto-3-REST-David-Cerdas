using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using RestSharp;
using Proyecto_3_REST_David_Cerdas.CSD;

namespace Proyecto_3_REST_David_Cerdas.CSU
{
    public partial class ConsultaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
               /*Crear una instancia del cloente de RestSharp para poder gestionar el servicio web
                         Se le pasa como parámetro el enlace hacia el servicio web
                                                         ↓                     */
            RestClient client = new RestClient("https://randomuser.me/api/");


            string Respuesta; //Para almacenar la respuesta en formato JSON.

            RestRequest request = new RestRequest();

            var response = client.Get(request);/*Simulamos la conexión al servicio web (client), utilizamos el método GET
                                                            para hacer una solicitud de que nos devuelva información, esta info se guardará en
                                                            la variable response*/

            Respuesta = response.Content; //Almaceno el resultado (JSON) en Respuesta (String)



            //Desserialización de JSON a String

            Resultados oResultado = JsonConvert.DeserializeObject<Resultados>(Respuesta);

            Usuario oUsuario = oResultado.results[0]; //Primer elemento de la lista. 


            //Enviar a los Textbox

            imgUsuario.ImageUrl = oUsuario.picture.large;

            tbTitulo.Text = oUsuario.name.title;

            tbNombre.Text = oUsuario.name.first;

            tbApellidos.Text = oUsuario.name.last;

            tbUsuario.Text = oUsuario.login.username;

            tbContrasena.Text = oUsuario.login.password;


        }//click btnConsultar
    }
}