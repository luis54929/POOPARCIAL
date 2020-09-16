using System;
using Edificios;
using Edificios.Salones;
using System.Collections;
using System.Collections.Generic;

namespace Edificios.Edificio{
    public class Edificio{

        #region Properties
            private DateTime reloj;
            private int cantSalones;
        public List<Salon> salones = new List<Salon>();
        #endregion Properties
        
        #region Methods
            public void setReloj(DateTime v)
            {
                reloj = v;
            }
            public DateTime getReloj()
            {
                return reloj;
            }   
            public int GetcantSalones()
            {
                return cantSalones;
            }

            public void SetcantSalones(int value)
            {
                cantSalones = value;
            }
            public void mostrarEstado(){
                if(salones.Count == 0){
                    Console.WriteLine("No hay salones aun en el sistema");
                }
                else{
                    List<DateTime> reservas = new List<DateTime>();
                    foreach (Salon s in salones)
                    {
                        reservas = s.obtenerReservas();
                        DateTime luces = reservas[0];
                        DateTime luces2 = reservas[1];
                        DateTime aire = luces;
                        DateTime aire2 = luces;
                        luces.AddMinutes(-5);
                        luces2.AddMinutes(10);
                        aire.AddMinutes(-10);
                        aire2.AddMinutes(-5);
                        int result = DateTime.Compare(luces,reloj);
                        if(result >= 0){
                            s.encenderLuz(true);
                            s.empezarClase();
                        }
                        result = DateTime.Compare(luces2,reloj);
                        if (result >= 0){
                            s.apagarLuz(false);
                        }
                        result = DateTime.Compare(aire,reloj);
                        if (result >= 0){
                            s.cambiarTemperatura(23);
                        }
                        result = DateTime.Compare(aire2,reloj);
                        if (result >= 0){
                            s.cambiarTemperatura(29);
                            s.terminarClase();
                        }
                        Console.WriteLine("====================================");
                        Console.WriteLine("Salon: "+ s.GetidSalon);
                        if(s.Getluces){
                            Console.WriteLine("Luces del salon: ENCENDIDAS");
                        }
                        else{
                            Console.WriteLine("Luces del salon: APAGADAS");
                        }
                        Console.WriteLine("Temperatura: "+ s.Gettemperatura);
                        if(s.GetestadoSalon){
                           Console.WriteLine("Estado del salon: SIN CLASE"); 
                        }
                        else{
                            Console.WriteLine("Estado del salon: EN CLASE");
                        }
                        Console.WriteLine("====================================");
                    }
                }
            }   
        #endregion Methods

    }
}
