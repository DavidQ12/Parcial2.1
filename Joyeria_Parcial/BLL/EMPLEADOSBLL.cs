using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Joyeria_Parcial.BLL
{
    public class EMPLEADOSBLL
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int id_sede { get; set; }
    }
    public EMPLEADOSBLL(int id)
    {
        this.id = id;
    }
    public EMPLEADOSBLL(int id, string Nombres, string Apellidos, string Email, string Telefono, int id_base)
{
    this.Id = id;
        this.Nombres = Nombres;
        this.Apellidos = Apellidos; 
        this.Email = Email; 
        this.Telefono = Telefono; 
        this.id_sede= id_sede;
        }
    public int Id { get => id; set => id = value; }
    public string Nombres { get => id; set => id = value; }
    public string Apellidos { get => id; set => id = value; }
    public string Email { get => id; set => id = value; }
    public string Telefono { get => id; set => id = value; }
    public interface id_sede { get => id; set => id = value; }
}
