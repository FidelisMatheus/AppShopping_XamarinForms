﻿using AppShopping.Libraries.Helpers.MVVM;
using AppShopping.Models;
using AppShopping.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AppShopping.ViewModels
{
    //primeiro o nome da propriedade dessa classe o segundo é o que recebeu, utilizamos o mesmo nome para evitar erros
    [QueryProperty("filmSerialized", "filmSerialized")]

    public class FilmDetailViewModel : BaseViewModel
    {
        public Film Film { get; set; }

        public string filmSerialized { 
            set
            {
                //Deserializar e atribuir ao Film.
                var decode = Uri.UnescapeDataString(value);
                var film = JsonConvert.DeserializeObject<Film>(decode);

                Film = film;
                OnPropertyChanged(nameof(Film));
            }
        }

        public FilmDetailViewModel()
        {
            
        }
    }
}
