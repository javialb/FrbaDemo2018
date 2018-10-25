﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Models.Auxiliares;
using System.Net.Mail;
using Models.Dominio;

namespace Models
{
	/// <summary>
	/// Clase que representa el modelo de Usuario conforme el dominio creado
	/// </summary>
	/// 
	/// Creación 18/07/2018
	///
	public class Usuario
	{
		#region Atributos
		
		public int UsuarioId { get; set; }
		public string password { get; set; } //password encriptado con SHA256
		public string userName { get; set;}
		//private MailAddress mail = null;
        //public IEnumerable<Rol> roles { get; set; }
		public bool eliminado { get; set; }
		public DateTime? fechaEliminacion { get; set; }
		#endregion

		#region Propiedades
  //      public string Mail
  //      {
  //          get 
  //          {
  //              if (mail != null)
  //                  return mail.Address;
  //              else
  //                  return "''";
  //          }
  //          set { if(value != "") 
  //                  mail = new MailAddress(value);}
  //      }
		//public int Telefono
  //      {
  //          get { return _telefono; }
  //          set { _telefono = value; }
  //      }
		//public string Fecha_nacimiento
  //      {
  //          get { return ((DateTime)fechaNacimiento).ToString("yyyyMMdd"); }
  //          set { fechaNacimiento = DateTime.Parse(value); }
  //      }

        //public DateTime? Fecha_nacimiento_struct
        //{
        //    get { return fechaNacimiento; }
        //    set { fechaNacimiento = value; }
        //}
		
		#endregion

		#region Constructor
		public Usuario()
		{
			this.eliminado = false;
			//this.habilitado = true;
		}
		#endregion

		//public bool estoyInhabilitado() { return habilitado; }
    }
}