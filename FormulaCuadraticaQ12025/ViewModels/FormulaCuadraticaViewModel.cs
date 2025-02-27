using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FormulaCuadraticaQ12025.ViewModels
{
    internal partial class FormulaCuadraticaViewModel : ObservableObject
    {
        [ObservableProperty]
        private double a;

        [ObservableProperty]
        private double b;

        [ObservableProperty]
        private double c;

        [ObservableProperty]
        private double x1;

        [ObservableProperty]
        private double x2;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            try
            {
                if (A == 0)
                {
                    Alerta("Advertencia", "Valor de a no puede ser igual a cero");
                }
                else
                {
                    double discriminante = Math.Pow(B, 2) - (4 * a * c);

                    if (discriminante < 0)
                    {
                        Alerta("Advertencia", "No se puede calcular la raiz cuadrada con numeros negativos");
                    }
                    else
                    {
                        X1 = (-B + Math.Sqrt(discriminante)) / (2 * a);
                        X2 = (-B - Math.Sqrt(discriminante)) / (2 * a);
                    }

                }
            }
            catch (Exception ex)
            {

                Alerta("ERROR", ex.Message);
            }

        }


        private void Limpiar()
        {
            A = 0;
            B = 0;
            C = 0;
            X1 = 0;
            X2 = 0;
        }




    }
}
