using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosePutoAmoWPF
{
    /*
     * Clase creada para trastear con los dibujos y tablas
     * 
     * Autor: Jorge Alvarez Ceñal
     * Fecha: 25/05/2022
     */
    class DTODibujos
    {
        // Atributos
        private int idDibujo;
        private string nombreDibujo;
        private string nombreFichero;
        private string descripcion;
        private string autor;


        // Constructor
        public DTODibujos(int idDibujo, string nombreDibujo, string nombreFichero, string descripcion, string autor)
        {
            this.idDibujo = idDibujo;
            this.nombreDibujo = nombreDibujo;
            this.nombreFichero = nombreFichero;
            this.descripcion = descripcion;
            this.autor = autor;
        }


        // Getters y Setters
        public int IdDibujo { get => idDibujo; set => idDibujo = value; }
        public string NombreDibujo { get => nombreDibujo; set => nombreDibujo = value; }
        public string NombreFichero { get => nombreFichero; set => nombreFichero = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Autor { get => autor; set => autor = value; }
    }
}
