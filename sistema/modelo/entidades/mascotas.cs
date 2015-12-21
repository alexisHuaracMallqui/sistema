using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.modelo.entidades
{
    class mascotas
    {
                private int id_Mascota;
        private string nombreDuenio;
        private string nombreMascota;
        private string tipoMascota;
        private int peso;
        private string raza;
        private int edad;

        public mascotas()
        { 
        }
        public mascotas( string nombreDuenio, string nombreMascota, string tipoMascota, int peso,
           string raza, int edad)
        {
            this.nombreDuenio = nombreDuenio;
            this.nombreMascota = nombreMascota;
            this.tipoMascota = tipoMascota;
            this.peso = peso;
            this.raza = raza;
            this.edad = edad;

        }

        public mascotas(int id_Mascota,string nombreDuenio,string nombreMascota,string tipoMascota,int peso,
            string raza,int edad)
        {
            this.id_Mascota = id_Mascota;
            this.nombreDuenio = nombreDuenio;
            this.nombreMascota = nombreMascota;
            this.tipoMascota = tipoMascota;
            this.peso = peso;
            this.raza = raza;
            this.edad = edad;

        }


        public int Id_Mascota
        {
            get { return id_Mascota; }
            set { id_Mascota = value; }
        }


        public string NombreDuenio
        {
            get { return nombreDuenio; }
            set { nombreDuenio = value; }
        }


        public string NombreMascota
        {
            get { return nombreMascota; }
            set { nombreMascota = value; }
        }


        public string TipoMascota
        {
            get { return tipoMascota; }
            set { tipoMascota = value; }
        }


        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }


        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }


        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

    }
}
