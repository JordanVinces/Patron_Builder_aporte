using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Entidades;

namespace ConsoleApplication1.Builder
{

    //CREACION DE LA INTERFAZ
    // ESTOS METODOS DEVUELVEN UN MATERIAS DISCOGRAFICO BUILDER
    public interface IMaterialDiscograficoBuilder
    {
        MaterialDiscograficoBuilder ConNombre(String nombre);
        MaterialDiscograficoBuilder TienePrecio(Double precio);
        MaterialDiscograficoBuilder EnStock(int stock);

        MaterialDiscograficoBuilder ComoGenero(Genero genero);
        MaterialDiscograficoBuilder ComoAutor(Autor autor);
        MaterialDiscograficoBuilder ComoTipoMaterialDiscografico(TipoMaterialDiscografico tipoMaterialDiscografico);
        MaterialDiscograficoBuilder ComoCanciones(List<Cancion> canciones);
    }
}
