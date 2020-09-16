using System;
using UsuariosC.usuarios;
using Edificios.Edificio;
using Edificios.Salones;
using System.Collections;
using System.Collections.Generic;
namespace UsuariosC.estandar{
    public class usuarioEstandar:Usuarios{
        public usuarioEstandar()
        {
            this.credencialEstandar = false;

        }
        #region Properties
        private bool credencialEstandar { get; set; }
        #endregion Properties
        
        #region Methods
        public bool realizarReserva(string id, DateTime h1, DateTime h2){
            bool flag = false;
            int comp;
            if(Edificio.salones.Count < Edificio.GetcantSalones()){
                Salon x;
                x.disponibilidadChange(false);
                x.reservasChange(h1,h2);
                Random id = new Random();
                x.SetidSalon(Convert.ToString(id.Next(1000,9999)));
                Edificio.salones.Add(x);

            }
            foreach (Salon s in Edificio.salones){
                comp = string.CompareOrdinal(s.GetidSalon(),id);
                if (comp == 0 && s.Getdisponibilidad == true){
                    if (s.disponibilidadChange)
                        s.disponibilidadChange(false);
                        s.reservasChange(h1,h2);
                }
            }
            if (flag = false){
                Console.WriteLine("Error salon no encontrado, inhabilitado u ocupado");
            }
        }
        #endregion Methods
    }
}