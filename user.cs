using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
    public class user
    {

        private string name;
        private int id;
        private int precio;
        private int cant;

        public int Id { get => id; set => id = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Cant { get => cant; set => cant = value; }
        public string Name { get => name; set => name = value; }
    }
}
