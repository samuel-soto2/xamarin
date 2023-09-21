using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace apkCalculadora
{
    public partial class MainPage : ContentPage
    {
        double res = 0;
        public MainPage()
        {
            InitializeComponent();
            wkOperacion.Items.Add("suma");
            wkOperacion.Items.Add("resta");
            wkOperacion.Items.Add("multiplicacion");
            wkOperacion.Items.Add("division");
            wkOperacion.SelectedIndexChanged += WkOperacion_SelectedIndexChanged;
            calcular.Clicked += Calcular_Clicked;

        }
