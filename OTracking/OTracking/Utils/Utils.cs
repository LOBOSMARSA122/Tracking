﻿using OTracking.Models.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace OTracking.Utils
{
    public class Utils
    {
        public static string Encrypt(string pData)
        {
            UnicodeEncoding parser = new UnicodeEncoding();
            byte[] _original = parser.GetBytes(pData);
            MD5CryptoServiceProvider Hash = new MD5CryptoServiceProvider();
            byte[] _encrypt = Hash.ComputeHash(_original);
            return Convert.ToBase64String(_encrypt);
        }

        public static List<Dropdownlist> LoadDropDownList(List<Dropdownlist> lista, string accion)
        {
            Dropdownlist oParametro = new Dropdownlist
            {
                Id = -1
            };

            if (accion == "Seleccionar")
                oParametro.Value = "--Seleccionar--";
            else
                oParametro.Value = "--Todos--";

            lista.Insert(0, oParametro);
            return lista;
        }


    }
}