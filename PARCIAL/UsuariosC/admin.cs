using System;
using UsuariosC.usuarios;
using Edificios.Edificio;
using Edificios.Salones;
using System.Collections;
using System.Collections.Generic;
using UsuariosC.estandar;
namespace UsuariosC.Admin
{
    public class admin : Usuarios{
        #region Properties
        public admin()
        {
            this.credencialAdmin = true;
            
        }
        private bool credencialAdmin { get; set; }
        #endregion Properties
        #region Methods
        public void inhabilitarSalon(String salonBuscar){
            bool flag = false;
            int result;
            foreach (Salon s in Edificio.salones){
                result = string.CompareOrdinal(s.GetidSalon,salonBuscar);
                if (result == 0 && s.Getdisponibilidad == true)
                {
                    flag = true;
                    if (s.disponibilidadEst())
                        s.disponibilidadChange(false);
                }
            }
            if (flag = false){
                Console.WriteLine("Error salon no encontrado o inhabilitado");
            }
        }
        public void habilitarSalon(String salonBuscar)
        {
            int result;
            bool flag = false;
            foreach (Salon s in Edificio.Salones)
            {
                result = string.CompareOrdinal(s.GetidSalon,salonBuscar);
                if (result == 0 && s.Getdisponibilidad == true)
                {
                    flag = true;
                    if (s.disponibilidadEst() == false)
                        s.disponibilidadChange(true);
                }

            }
            if (flag = false)
            {
                Console.WriteLine("Error salon no encontrado o inhabilitado");
            }
        }
        public void modificarTemperatura(String salonBuscar, int temp)
        {
            int result;
            bool flag = false;
            foreach (Salon s in Edificio.Salones)
            {
                result = string.CompareOrdinal(s.GetidSalon,salonBuscar);
                if (result == 0 && s.Getdisponibilidad == true)
                {
                    s.cambiarTemperatura(temp);
                    flag = true;
                }

            }
            if (flag = false)
            {
                Console.WriteLine("Error salon no encontrado o inhabilitado");
            }
        }
        #endregion Methods
    }
}