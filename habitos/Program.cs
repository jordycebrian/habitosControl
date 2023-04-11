using habitos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class habitosApp
{
    public static void Main()
    {
        
        string opcion = ""; // variable opciones del programa
        opcion.ToLower();
        while (opcion != "salir")
        {
            Console.Clear();    // limpiar consola
            opcion.ToLower();
            Console.WriteLine("-----------Bienvenido a tu lista de habitos------------");
            Console.WriteLine("---------------Opciones del Programa-------------------");
            Console.WriteLine("\tEscibir \"salir\" para cerrar del programa");
            Console.WriteLine("\tEscibir \"1\" para MOSTRAR la lista de habito");
            Console.WriteLine("\tEscibir \"2\" para AGREGAR un habito");
            Console.WriteLine("\tEscibir \"3\" para MODIFICAR un habito");
            Console.WriteLine("\tEscibir \"4\" para BORRAR un habito");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("\tNota: SOLO ESTAS OPCIONES SE ADMITEN");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Que deseas hacer > ");
            opcion = Console.ReadLine() + "";


            #region OPCIONES DE LA APLICACIÓN
            //acciones a realizar
            if (opcion == "1")
            {
                CrudHabitos.MostrarHabitos();
            }
            if (opcion == "2")
            {
                CrudHabitos.AgregarHabito();
            }
            if (opcion == "3")
            {
                CrudHabitos.EditarHabito();
            }
            if (opcion == "4")
            {
                CrudHabitos.EliminarHabito();
            }
            if (opcion == "salir")
            {
                //cerrar la consola
                Environment.Exit(0);
                Environment.ExitCode = 0;
            }
            #endregion


        }
    }


}