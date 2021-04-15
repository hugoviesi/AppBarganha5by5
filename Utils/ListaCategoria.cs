using AppBarganhaWEB.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppBarganhaWEB.Utils
{
    public class ListaCategoria
    {
        public static MultiSelectList Lista()
        {
            var categorias = Enum.GetValues(typeof(Categoria)).Cast<Categoria>();

            //typeof: verifica o tipo do parâmetro passado
            //cast: converte um Enum em um tipo específico

            List<SelectListItem> selectListItems = new List<SelectListItem>();

            foreach (Categoria categoria in categorias)
            {
                var selectList = new SelectListItem()
                {
                    Text = categoria.ToString(),
                    Value = ((int)categoria).ToString()
                };
                selectListItems.Add(selectList);
            }

            return new MultiSelectList(selectListItems, "Value", "Text");
        }

    }
}
