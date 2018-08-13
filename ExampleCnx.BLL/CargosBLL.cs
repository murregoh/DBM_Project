using ExampleCnx.DAL;
using System;
using System.Data;

namespace ExampleCnx.BLL
{
    public class CargosBLL
    {
        
        public DataTable ConsultarCargos()
        {
            CargosDAL cargosDal = new CargosDAL();
            return cargosDal.ConsultarCargos();
        }

        public String CrearCargo(String nomCargo) {

            bool CrearCargosDal = new CargosDAL().InsertarCargo(nomCargo);

            if (CrearCargosDal)
            {
                return "El cargo se ha creado correctamente";
            }
            else
            {
                return "El cargo no se pudo crear";
            }
        }

        public bool ActualizarCargo(int id, string cargo)
        {
            return new CargosDAL().ActualizarCargo(id, cargo);
        }
    }
}
