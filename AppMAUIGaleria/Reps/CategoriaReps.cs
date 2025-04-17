using AppMAUIGaleria.Models;
using AppMAUIGaleria.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGaleria.Reps {
    internal class CategoriaReps {
        public CategoriaReps() { }
        public List<Categoria> GetCategorias() {
            List<Categoria> categorias = new List<Categoria>();
            categorias.Add(new Categoria() {
                Name = "Layout",
                Componentes = new List<Componente> {
                    new Componente {
                        Titulo = "StackLayout",
                        Descricao = "Apenas testando a funcionalidade.",
                        Pagina = new StackLayoutPage()
                    }
                }
            });

            return categorias;
        }
    }
}
