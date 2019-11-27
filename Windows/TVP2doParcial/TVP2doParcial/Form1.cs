using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TVP2doParcial
{
    public partial class Form1 : Form
    {
        //Variables
        ArrayList palabras = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*  1. Describa en sus propias palabras el concepto de colecciones (collections) y cuales tipos existen.
             *      R: Son objetos que ayudan al manejo y la manipoulación de variables y objetos.
             *      
                2. Defina a que se refiere el concepto de código no seguro y que se necesita para implementarlo.
                    R: Es una forma de llamar al codigo cuando se espera tener errores, se suele implementar cuando hacemos uso de apuntadores.

                3. Mencione al menos tres clases que se utilizan en I/O y proporcione brevemente la idea central de las mismas.
                    R: FileStream: Lee y escribe bytes desde y hacia un archivo.
                       MemoryStream: Lee y escribe bytes desde y hacia la memoria.
                       PipeStream: Lee y escribe bytes desde y hacia los procesos.

                4. Explique la diferencia entre los siguientes códigos en csharp
                    a. Console.Writeline ("resultado: (*ptr) ").
                            En este se imprime la variable que llega solamente.
                    b. Console.WriteLine("resultado: ((int)ptr)")
                            En este antes de imrpimir lo castamos para que nos convierta en valor a entero.

                5. Mencione al menos tres caracteristicas de las excepciones (Exceptions).
                    R: Es un evento inesperado en programa, Se representan mediante clases, Se utilizan instrucciones como try y catch.

                6. En Java, mencione y describa los tres tipos de excepciones.
                    R: System.IO.IOException: Es cuando existe un error de entrada y salida de datos.
                       System.DivideByZeroException: Es cuando dividimos un valor entre 0.
                       System.StackOverflowException: Es cuando existe un desbordamiento de pila.

                7. Explique brevemente a que se refiere con directivas para preprocesador y que se necesita para usarlas.
                    R: Es una instruccion que le enviamos al compialdro para que rocese una iformacion antes de compilar el programa,
                    por ejemplo una constante es un valor que permane igual en todo el código.

                8. Explique las diferencias entre ArrayList, Sorted List Hash Table.
                    R: ArrayList:  Es un arreglo, pero en este no debe especificarse el tamaño, ya que se acumula conforme reciba valores.
                       SortedList: Es una tabla que contiene un valor y una llave (ID) y las comoda de manera ascendente.
                       HashTable: Es igual que el SortedList, pero este no los acomoda de manera ascendente, se accede a los datos atraves de la llave.

                9. Describa para que sirven StreamReader y StreamWriter
                    R: Son clases que ayudan a la lectura y escritura, convierte bytes en caracteres y viseversa.

                10. Explique el funcionamiento del algoritmo Quicksort
                    R: Es un algoritmo que nos ayuda al acomodo o representaciónded datos, este comienza con un pivote y
                       apartir de este separa la lista en dos partes, acomoda a la derecha los mayores y a la izquierda los menores.

                11. En Java, explique cuál es la diferencia entre System.out, System.in y System.err
                    R: System.out: Es para la salida estandar de datos, System.in: Es para el ingreso de datos y System.err: es para la salida de errores.\

                12. Explique cuáles son las ventajas de utilizar "generic collections"
                    R: Tienen funcionalidades propias que los no genericos (por ejemplo: List<T>) y perimten delegados.

             
             */

            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String pal;
            pal = (txtIngreso.Text);
            palabras.Add(pal);
        }

        private void ctnCalcular_Click(object sender, EventArgs e)
        {
            Result rs = new Result(palabras);
            //rs.MdiParent = this;
            rs.Show();
            
        }
    }
}
