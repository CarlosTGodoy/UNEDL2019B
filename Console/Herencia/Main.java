package Herencia;

public class Main {
    public static void main (String [] args){
        Hijo Carlos = new Hijo("Cafés","Lacio","Café","Claro", (float) 1.72,"Sí","Sí");
        Carlos.Mostrar(); //Llamamos los atributos que heredamos en el metodo de la clase hijo
        
        //Llamamos con nuestro objeto los metodos que tenga nuestra clase padre, ya que los hemos heredado directamente
        System.out.println("\nLos métodos que he heredado");
        Carlos.Caracter();
        Carlos.GestoBoca();
        Carlos.Risa();
        
        //Llamamos con nuestro objeto los metodos que he aprendido de otras personas
        System.out.println("\nLos metodos que he aprendido de otras partes externas a mi herencia (padres)");
        System.out.println("Amigos: ");
        Carlos.Expresion();
        System.out.println("Maestros: ");
        Carlos.FormaDeTrabajo();
        System.out.println("Jefes anteriores");
        Carlos.Disciplina();
        
    }
}