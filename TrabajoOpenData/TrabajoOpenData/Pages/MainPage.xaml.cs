using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace TrabajoOpenData
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            if (internetConnectionCheck())
            {

            }
            else
            {
                bool respuesta = DisplayAlert("No tienes acceso a internet", "¿Quieres intentar conectarte?", "Si", "No").Result;
                if (respuesta)
                {
                    var profiles = Connectivity.ConnectionProfiles;
                    if (profiles.Contains(ConnectionProfile.WiFi))
                    {
                        
                    }
                    else
                    {
                        DisplayAlert("Error de conexión", "No se puede conectar a internet", "Aceptar");
                    }
                }
            }
        }

        private bool internetConnectionCheck()
        {
            var current = Connectivity.NetworkAccess;
            return current == NetworkAccess.Internet;           
        }
    }
}
