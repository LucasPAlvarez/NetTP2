using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola {
    public class Usuarios {

        UsuarioLogic UsuarioNegocio;

        public Usuarios() {
            UsuarioNegocio = new UsuarioLogic();
        }

        public void Menu() {

            ConsoleKey keyPressed;
            bool loopOn = true;

            while (loopOn) {

                Console.WriteLine("1– Listado General\n2– Consulta\n3– Agregar\n4 - Modificar\n5 - Eliminar\n6 - Salir");
                keyPressed = Console.ReadKey().Key;

                switch (keyPressed) {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        ListadoGeneral();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Consultar();
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Agregar();
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        Modificar();
                        break;
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        Eliminar();
                        break;
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D6:
                        loopOn = false;
                        break;
                    default:
                        break;
                }
            }
        }


        public void ListadoGeneral() {
            Console.Clear();
            foreach (Usuario user in UsuarioNegocio.GetAll()) {
                MostrarDatos(user);
            }
        }

        public void MostrarDatos(Usuario user) {
            //hacer la funcion que muestre todos los datos
            Console.WriteLine("Usuario: (0)", user.ID);
            Console.WriteLine("\t\tNombre: (0)", user.Nombre);
            Console.WriteLine("\t\tApellido: (0)", user.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: (0)", user.NombreUsuario);
            Console.WriteLine("\t\tClave: (0)", user.Clave);
            Console.WriteLine("\t\tEmail: (0)", user.EMail);
            Console.WriteLine("\t\tHabilitado: (0)", user.Habilitado);
            Console.WriteLine();
        }


        public void Consultar() {
            try {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a consultar:");
                int ID = int.Parse(Console.ReadLine());
                MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException e) {
                Console.WriteLine("La ID ingresada debe ser un número entero”.");
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
            finally{
                Console.WriteLine("ingrese una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Agregar() {
            Console.Clear();
            Usuario user = new Usuario();

            Console.WriteLine("Ingrese el Nombre");
            user.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido");
            user.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el nobre de usuario");
            user.NombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña");
            user.Clave = Console.ReadLine();
            Console.WriteLine("Ingrese el email");
            user.EMail = Console.ReadLine();
            Console.WriteLine("Ingrese la habilitacion del usuario (1- SI/ otros- No)");
            user.Habilitado = ("1" == Console.ReadLine());

            user.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(user);

            Console.WriteLine("Usuario ID (0)", user.ID);
            Console.ReadKey();
        }

        public void Modificar() {
            try {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a modificar:");
                int ID = int.Parse(Console.ReadLine());
                Usuario user = UsuarioNegocio.GetOne(ID);

                Console.WriteLine("Ingrese el Nombre");
                user.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el Apellido");
                user.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese el nobre de usuario");
                user.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese la contraseña");
                user.Clave = Console.ReadLine();
                Console.WriteLine("Ingrese el email");
                user.EMail = Console.ReadLine();
                Console.WriteLine("Ingrese la habilitacion del usuario (1- SI/ otros- No)");
                user.Habilitado = ( "1" == Console.ReadLine());

                user.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(user);
            }
            catch (FormatException e) {
                Console.WriteLine("La ID ingresada debe ser un número entero”.");
            }
            catch(Exception e) {
                Console.WriteLine(e);
            }
            finally {
                Console.WriteLine("ingrese una tecla para continuar");
                Console.ReadKey();
            }
        }
        public void Eliminar() {
            try {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a eliminar:");
                int ID = int.Parse(Console.ReadLine());

                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException e) {
                Console.WriteLine("La ID ingresada debe ser un número entero”.");
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
            finally {
                Console.WriteLine("ingrese una tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
