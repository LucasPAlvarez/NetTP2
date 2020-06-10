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

            Console.WriteLine("1– Listado General\n2– Consulta\n3– Agregar\n4 - Modificar\n5 - Eliminar\n6 - Salir");
            keyPressed = Console.ReadKey().Key;

            switch (keyPressed) {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:

                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:

                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:

                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:

                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:

                    break;
                case ConsoleKey.NumPad6:
                case ConsoleKey.D6:

                    break;
                default:
                    break;
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
            Console.WriteLine("\t\tNombre: (0)", user.nombre);
            Console.WriteLine("\t\tApellido: (0)", user.apellido);
            Console.WriteLine("\t\tNombre de Usuario: (0)", user.nombreUsuario);
            Console.WriteLine("\t\tClave: (0)", user.clave);
            Console.WriteLine("\t\tEmail: (0)", user.email);
            Console.WriteLine("\t\tHabilitado: (0)", user.habilitado);
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
            user.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido");
            user.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el nobre de usuario");
            user.nombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña");
            user.clave = Console.ReadLine();
            Console.WriteLine("Ingrese el email");
            user.email = Console.ReadLine();
            Console.WriteLine("Ingrese la habilitacion del usuario (1- SI/ otros- No)");
            user.habilitado = ("1" == Console.ReadLine());

            user.state = BusinessEntity.States.New;
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
                user.nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el Apellido");
                user.apellido = Console.ReadLine();
                Console.WriteLine("Ingrese el nobre de usuario");
                user.nombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese la contraseña");
                user.clave = Console.ReadLine();
                Console.WriteLine("Ingrese el email");
                user.email = Console.ReadLine();
                Console.WriteLine("Ingrese la habilitacion del usuario (1- SI/ otros- No)");
                user.habilitado = ( "1" == Console.ReadLine());

                user.state = BusinessEntity.States.Modified;
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
