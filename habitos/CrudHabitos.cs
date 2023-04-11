using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//AQUI IRAN LAS OPCIONES DE LA APLICACION
namespace habitos
{
    public class CrudHabitos
    {

        #region VARIABLES GLOBAS
        public const string OPCION_SALIR = "salir";
        public static List<string> ListaHabitos = new List<string>();
        #endregion


        #region METODO AGREGAR REGION
        public static void AgregarHabito()
        {
            

            Console.Clear();
            Console.WriteLine("AGREGAR HABITOS A TU LISTA");
            Console.WriteLine($"Escribe {OPCION_SALIR} para regresar al menu");
            string opcion = ""; // opciones del programa

            //Minetras no sea la opcion salir
            while (opcion != OPCION_SALIR)
            {
                Console.Write("Ingresa tu habito > ");
                opcion = Console.ReadLine();
                if (opcion != OPCION_SALIR)
                {
                    ListaHabitos.Add(opcion);
                    Console.WriteLine($"Tu habito [{opcion}] se ha guardado correctamente");
                }
               
            }

        }
        #endregion


        #region METODO MOSTRAR HABITOS
        public static void MostrarHabitos()
        {


            Console.Clear();
            Console.WriteLine("----------------AQUI ESTA TU LISTA DE HABITOS-----------------\n");
            //mostrando habitos
            if (ListaHabitos.Count >= 1)
            {
                int index = 0;
                foreach (string habitos in ListaHabitos)
                {
                    index++;
                    Console.WriteLine($"\t\t[{index}] {habitos}");
                }
                Console.WriteLine("\n--------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("\t\tNo hay habitos para mostrar :(");
                Console.WriteLine("-----------------------------------------------------------");
            }
            //opcinon para salir y que no se cierre rapido la ventana
            Console.Write("Presiona la tecla \"ENTER\" para salir");
            Console.ReadLine();
            
        }
        #endregion


        #region METODO EDITAR HABITOS
        public static void EditarHabito()
        {
            Console.Clear();

            Console.WriteLine("----------------LISTA DE HABITOS-----------------\n");
            //mostrando habitos para poder ver que habito se borra
            if (ListaHabitos.Count >= 1)
            {
                int contador = 0; // variable para generar indice a habitos
                foreach (string habitos in ListaHabitos)
                {
                    contador++;
                    Console.WriteLine($"\t\t[{contador}] {habitos}");
                }
                Console.WriteLine("\n--------------------------------------------------------\n");

                //Editando habito en base a entrada
                string habitoEditar = "";

                Console.Write("Que habito quieres editar > ");

                int.TryParse(Console.ReadLine(), out int NumHabito);
                for (int i = 0; i < ListaHabitos.Count; i++)
                {

                        //si es igual a index del elemento
                        if (NumHabito == i + 1)
                        {
                            Console.Write("Escribe el habito nuevamente > ");
                            habitoEditar = Console.ReadLine();
                            ListaHabitos[i] = habitoEditar;

                            Console.WriteLine($"El habito {NumHabito} ha sido editado con exito\nEnter para salir");
                            Console.ReadLine();
                            //readline para detener y espera el enter

                        }
                        else
                        {
                            Console.WriteLine("Opcion no valida!! solo habitos disponibles :/");
                            Console.WriteLine("Presiona ENTER pasa salir");
                            Console.ReadLine();
                        }
                        
                }
                




            }
            else
            {
                //readline para detener y espera el enter
                Console.WriteLine("NO hay elementos en la lista para Edtar\n");
                Console.WriteLine("Presiona ENTER para salir");
                Console.ReadLine();
            }

        }

        #endregion


        #region METODO ELIMINAR HABITO
        public static void EliminarHabito()
        {
            Console.Clear();
            
            Console.WriteLine("----------------LISTA DE HABITOS-----------------\n");
            //mostrando habitos para poder ver que habito se borra
            if (ListaHabitos.Count >= 1)
            {
                int c = 0; // variable para generar indice a habitos
                foreach (string habitos in ListaHabitos)
                {
                    c++;
                    Console.WriteLine($"\t\t[{c}] {habitos}");
                }
                Console.WriteLine("\n--------------------------------------------------------\n");

                //Borrando habito en base a entrada
                int NumHabito = 0;
                Console.WriteLine("Que habito quieres eliminar");
                NumHabito = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < ListaHabitos.Count; i++)
                {
                    //si es igual a index del elemento
                    if (NumHabito == i + 1)
                    {
                        ListaHabitos.RemoveAt(i);
                        Console.WriteLine($"El habito {NumHabito} ha sido eliminado con exito");
                        //readline para detener y espera el enter
                        Console.WriteLine("Presiona ENTER para salir");
                        Console.ReadLine();
                    }
                }

            }
            else 
            {
                //readline para detener y espera el enter
                Console.WriteLine("NO hay elementos en la lista para borrar\n");
                Console.WriteLine("Presiona ENTER para salir");
                Console.ReadLine();
            }

            
            
        }
        #endregion 
    }
}
