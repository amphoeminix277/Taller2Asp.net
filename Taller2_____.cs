using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    class Program
    {
        static void Main(string[] args)
        {
t		SolucionTaller2 Uno=new SolucionTaller2(); 
        }

        class SolucionTaller2
        {
            
            SolucionTaller2()
            {
                Console.WriteLine("1.Construir un arreglo de objetos anónimos, con mínimo 30 registros diferentes, con la siguiente estructura:");
                
                var personas = new[] {
                new {nombre = "Camilo", apellido="Martinez",edad=25,sexo="M",pais="Colombia",correo="camilo@gmail.com"},
                new {nombre = "Abelardo", apellido="Gomez",edad=34,sexo="M",pais="Peru",correo="Ab@gmail.com"},
                new {nombre = "Fabian", apellido="Lopez",edad=29,sexo="M",pais="Ecuador",correo="fablop@gmail.com"},
                new {nombre = "Lina", apellido="Almanza",edad=17,sexo="F",pais="Brasil",correo="Linh@gmail.com"},
                new {nombre = "Esteban", apellido="Yepez",edad=30,sexo="M",pais="Peru",correo="yep@hotmail.com"},
                new {nombre = "Elizabeth", apellido="rodriguez",edad=40,sexo="F",pais="Paraguay",correo="eliro@yahoo.com"},
                new {nombre = "Miguel", apellido="Perez",edad=50,sexo="M",pais="Chile",correo="Mper@hotmail.com"},
                new {nombre = "Valentina", apellido="Cano",edad=60,sexo="F",pais="Uruguay",correo="valcan@gmail.com"},
                new {nombre = "Luis", apellido="Trujillo",edad=70,sexo="M",pais="Alemania",correo="lustru@gmail.com"},
                new {nombre = "Olga", apellido="Garcia",edad=80,sexo="F",pais="Rusia",correo="adafg@yahoo.com"},
                new {nombre = "Viviana", apellido="Ballesteros",edad=90,sexo="F",pais="Francia",correo="cegb@hotmail.com"},
                new {nombre = "Jesus", apellido="Ayala",edad=34,sexo="M",pais="Uruguay",correo="jeasy@gmail.com"},
                new {nombre = "Jhon", apellido="Cifuentes",edad=39,sexo="M",pais="Venezuela",correo="jhoncig@gmail.com"},
                new {nombre = "Duglas", apellido="Montez",edad=44,sexo="M",pais="Peru",correo="duglmont@gmail.com"},
                new {nombre = "Andrea", apellido="Salavarrieta",edad=49,sexo="F",pais="Colombia",correo="andressaldo@gmail.com"},
                new {nombre = "Sara", apellido="Segura",edad=54,sexo="F",pais="Suecia",correo="sarasegu@itc.edu.co."},
                new {nombre = "Norma", apellido="Prieto",edad=59,sexo="F",pais="Suiza",correo="norpri@gmail.com"},
                new {nombre = "Margarita", apellido="Sandoval",edad=64,sexo="F",pais="Colombia",correo="doplaor@gmail.com"},
                new {nombre = "Daniela", apellido="Zapata",edad=69,sexo="F",pais="Argentina",correo="kiurtu@hotmail.com"},
                new {nombre = "Daniel", apellido="Montez",edad=14,sexo="M",pais="Bolivia",correo="ad324@gmail.com"},
                new {nombre = "Javier", apellido="Miranda",edad=19,sexo="M",pais="Grecia",correo="poldo59@gmail.com"},
                new {nombre = "Luz", apellido="Martinez",edad=24,sexo="F",pais="Italia",correo="sercus@hotmail.com"},
                new {nombre = "Sofia", apellido="Castro",edad=29,sexo="F",pais="Nueva Zelanda",correo="sofitres@hotmail.com"},
                new {nombre = "Sergio", apellido="Lopez",edad=18,sexo="M",pais="Peru",correo="sercar@hotmail.com"},
                new {nombre = "Gabriel", apellido="Asprilla",edad=23,sexo="M",pais="Chile",correo="gabaris@itc.edu.co."},
                new {nombre = "Santiago", apellido="Monsteco",edad=28,sexo="M",pais="Ecuador",correo="sanitmon@itc.edu.co."},
                new {nombre = "Edgardo", apellido="Capuleto",edad=33,sexo="M",pais="Venezuela",correo="edagrpul@hotmail.com"},
                new {nombre = "Felipe", apellido="Medina",edad=25,sexo="M",pais="Canada",correo="felipemedi@gmail.com"},
                new {nombre = "Julian", apellido="Paez",edad=61,sexo="M",pais="Mexico",correo="julipa@homail.com"},
                new {nombre = "Cecilia", apellido="Alvarez",edad=37,sexo="F",pais="Guatemala",correo="cecilia15965@yahoo.com"},
        };
        //________________________________________________________________
                Console.WriteLine("____________________________________");
                Console.WriteLine("2. Consultar todas las mujeres del grupo.");
                var Consultarmujeres = from f in personas
                               where f.sexo.ToUpper().StartsWith("F")
                               select f;

                foreach (var persona in Consultarmujeres)
                {
                    Console.WriteLine("Nombre: {0}, Sexo: {1}", persona.nombre, persona.sexo);

                }
               

         //________________________________________________________________
                Console.WriteLine("____________________________________");
                Console.WriteLine("3. Consultar sólo las personas cuyo apellido termine con la letra z y que vivan en Colombia.");
                var PersonasZ = from z in personas
                               where z.sexo.ToUpper().Endswith("Z") && z.pais=="colombia"
                               select z;

                foreach (var persona in PersonasZ)
                {
                    Console.WriteLine("Nombre: {0}, Apellido: {1}, Pais{2}", persona.nombre, persona.apellido,persona.pais);

                }
                

                //________________________________________________________________
                Console.WriteLine("____________________________________");
                Console.WriteLine("4. Consultar las personas cuya edad esté entre los 18 y los 50, ordenar los resultados por sexo, luego por apellido en forma descendente.");
                var EdadesEntre = from edades in personas
                               where (edades.edad>18 && edades.edad<50) orderby edades.edad,edades.apellido descending
                               select edades;

                foreach (var persona in EdadesEntre)
                {
                    Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad:{2} ", persona.nombre, persona.apellido,persona.edad);

                }
                  

                //________________________________________________________________
                Console.WriteLine("____________________________________");
                Console.WriteLine("5. Consultar sólo el Nombre y Apellidos de las personas del arreglo y agregarle una unidad a la edad.");
                var SoloNombresYApellidos = from NomApe in personas
                               where NomApe.nombre
                               select NomApe;

                foreach (var persona in SoloNombresYApellidos)
                {
                    Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad Antes: {2}, Edad Aumentada en 1: {3}", persona.nombre, persona.apellido,persona.edad,persona.edad+1);

                }
                 
                //________________________________________________________________
                Console.WriteLine("____________________________________");
                Console.WriteLine("6. Consultar las personas cuyo correo sea del dominio gmail.com.");
                var gmail = from emails in personas
                               where emails.correo.EndsWith("gmail.com")
                               select emails;

                foreach (var persona in gmail)
                {
                    Console.WriteLine("Nombre: {0}, Correo: {1}", persona.nombre, persona.correo);

                }
                
                //________________________________________________________________
                Console.WriteLine("____________________________________");
                Console.WriteLine("7. Consultar Los hombre cuya edad supere los 20 años, que viva en Colombia, o Perú, o Venezuela y ordenarlos en orden descendente por edad y luego por nombre de forma ascendente.");
                var HombresPaises = from hombres in personas
                               where hombres.edad>20 &&(hombres.pais=="Colombia" || hombres.pais=="Peru" || hombres.pais=="Venezuela") orderby hombres.edad descending , hombres.nombre ascending
                               select hombres;

                foreach (var persona in HombresPaises)
                {
                    Console.WriteLine("Nombre: {0}, Sexo: {1}, Pais:{2}", persona.nombre, persona.sexo,persona.pais);

                }
                

                //________________________________________________________________
                Console.WriteLine("____________________________________");
                Console.WriteLine("8. Consultar en orden ascendente según la edad a todas las personas y tomar sólo las primeras 5 personas.");
                var CincoRegistros = from Cinco in personas
                               where persona.nombre orderby persona.edad ascending
                               select Cinco;

                foreach (var persona in CincoRegistros.Take(5))
                {
                    Console.WriteLine("Nombre: {0}, Edad: {1}", persona.nombre, persona.edad);

                }
               

                //________________________________________________________________
                Console.WriteLine("____________________________________");
                Console.WriteLine("9. Contar cuántas personas tienen correo de itc.edu.co.");
                var itcgmail = from itc in personas
                               where itc.correo.EndsWith("itc.edu.co")
                               select itc;

                foreach (var persona in itcgmail.Count())
                {
                    Console.WriteLine("Nombre: {0}, Correo: {1}", persona.nombre, persona.correo);

                }
                
                //________________________________________________________________
                Console.write("____________________________________");
                Console.write("10. Obtener el promedio de edades de todas las personas");
                var Promedio = (from pro in personas
                               where pro.edad
                               select pro).Average();

                
                    Console.WriteLine("El promedio de las edades es: "+promedio);

                
               

                //________________________________________________________________
                Console.write("____________________________________");
                Console.write("11. Consultar todas las personas que viven en Colombia y sólo traer el primero y último registro.");
                var PrimeroYUltimo = (from PrimUlt in personas 
                         select PrimUlt.pais).First() &&(from PrimUlt in personas 
                         select PrimUlt.pais).Last() ;

                foreach (var persona in PrimeroYUltimo)
                {
                    Console.WriteLine("Nombre: {0}, Pais: {1}", persona.nombre, persona.pais);

                }
               
                //________________________________________________________________
                Console.Write("____________________________________");
                Console.write("12. Consultar a las mujeres cuyo nombre inicie con “M”, su apellido termina con “z”.");
                var ConsultarmujeresMZ = from NombreApellido in personas
                                where (NombreApellido.sexo.ToUpper().StartsWith("F")) && 
                                (NombreApellido.nombre.ToUpper().StartsWith("m")) && 
                                (NombreApellido.sexo.ToUpper().EndsWith("z")) && 
                               select f;

                foreach (var persona in ConsultarmujeresMZ)
                {
                    Console.WriteLine("Nombre: {0}, Sexo: {1}", persona.nombre, persona.sexo);

                }
                //________________________________________________________________
                    Console.Write("____________________________________");
                Console.write("13. Contar la cantidad de veces que aparece una letra digitada por el usuario en una frase que también debe digitar el usuario. Ejemplo, si el usuario digita como letra ‘i’ y luego escribe la frase “El día de hoy iré a la iglesia”; el programa debe contar la cantidad de ies, es decir 4. (Hacer este ejercicio con LinQ).");
                
                Console.WriteLine("Digite Una frase");
                var frase=Console.ReadLine();

                Console.WriteLine("Digite Una letra");
                var letra=Console.ReadLine();

                
                
                var ContarLetras = (from Contar in frase
                                where frase=letra
                               select f).Count();
                Console.WriteLine("La cantidad de "+letra+"'s en "+frase+" es:"+ContarLetras+"veces");    
                
                //________________________________________________________________



                Console.ReadKey();

            }

        }
    }
}
