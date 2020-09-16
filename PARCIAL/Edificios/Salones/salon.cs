using UsuariosC.estandar;
using System;
using System.Collections;
using System.Collections.Generic;
namespace Edificios.Salones
{
    public class Salon
    {
        #region Properties
        public Salon( DateTime reserva1, DateTime reserva2)
        {
            this.Settemperatura(23);
            this.Setluces(false);
            this.SetestadoSalon(true);
            this.Setdisponibilidad(true);
            this.reserva1 = reserva1;
            this.reserva2 = reserva2;

        }
        private string idSalon;
        private int temperatura;
        private bool luces;
        private bool estadoSalon;
        private bool disponibilidad;

        private DateTime reserva1 { get; set; }
        private DateTime reserva2 { get; set; }
   

        #endregion Properties

        #region Methods
        public bool Getdisponibilidad()
        {
            return disponibilidad;
        }

        public void Setdisponibilidad(bool value)
        {
            disponibilidad = value;
        }
        public bool Getluces()
        {
            return luces;
        }

        public void Setluces(bool value)
        {
            luces = value;
        }
        public bool GetestadoSalon()
        {
            return estadoSalon;
        }

        public void SetestadoSalon(bool value)
        {
            estadoSalon = value;
        }
        public int Gettemperatura()
        {
            return temperatura;
        }

        public void Settemperatura(int value)
        {
            temperatura = value;
        }
        public string GetidSalon()
        {
            return idSalon;
        }

        public void SetidSalon(string value)
        {
            idSalon = value;
        }
        public void encenderLuz()
        {
            Setluces(true);
        }
        public void apagarLuz()
        {
            Setluces(false);
        }
        public void cambiarTemperatura(int temp)
        {
            Settemperatura(temp);
        }
        public void disponibilidadChange(bool change)
        {
            Setdisponibilidad(change);
        }
        public bool disponibilidadEst()
        {
            return Getdisponibilidad();
        }
        public void reservasChange(DateTime a, DateTime b)
        {
            reserva1 = a;
            reserva2 = b;
        }
        public list<DateTime> obtenerReservas(){
            List<DateTime> reservas = new List<DateTime>();
            reservas.Add(reserva1);
            reservas.Add(reserva2);
            return reservas;

        }
        public void empezarClase(){
            SetestadoSalon(false);
        }
        public void terminarClase(){
            SetestadoSalon(true);
        }
        #endregion Methods
    }
}