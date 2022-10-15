using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_Parcial.BLL
{
    public class SEDESBLL
    {
        private int Id_sede;
        private string Nombre_sede;
        private string Ubicacion;
        private string Telefono;
    }
    public SEDESBLL(int Id_sede)
    {
        this.Id_sede = Id_sede;
    }
    public SEDESBLL(int Id_sede, string Nombre_sede, string Ubicacion, string Telefono);
    
    {
    this.Id_sede = Id_sede; 
        this.Nombre_Sede = Nombre_Sede;
        this.Ubicacion = Ubicacion; 
        this.Telefono = Telefono;
    }
    public int Id_sede { get => id_sede; set => id_sede = value; }
    public int string Nombre_sede { get => nombre_sede; set => nomnbre_sede = value; }
    public string Ublicacion { get => ubicacion; set => ubicacion = value; }
    public string Telefono { get => telefono; set => telefono = value; }




}
