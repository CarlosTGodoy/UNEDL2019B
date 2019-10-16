package examen_primer_parcial;

import java.util.Scanner;


public class Main {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        //Objeto para conectar nuestras clases
        Habitacion habitacion1 = new Habitacion();
        Tapiz tapiz1 = new Tapiz();
        Calculadora calculadora1 = new Calculadora();
        
        //Variables
        String comprobacionAncho = "";
        String comprobacionLargo = "";
        String comprobacionPrecio = "";
        float ancho = 0;
        float largo = 0;
        float precio = 0;
        float costoTotal = 0;
        
        System.out.println(" --- CALCULAR PRECIO DE TAPIZ ---");
        System.out.println("Ingrese los datos que le se piden: ");
        
        System.out.println("Ancho de la habitación: ");
        comprobacionAncho = entrada.next();
        ancho = Float.parseFloat(comprobacionAncho);
        habitacion1.setAncho(ancho);
        
        //faltas1.setFaltasAbril(entrada.nextInt());
        
        System.out.println("Largo de la habitación: ");
        comprobacionLargo = entrada.next();
        largo = Float.parseFloat(comprobacionLargo);
        habitacion1.setLargo(largo);
        
        System.out.println("Precio por m2 del tapiz: ");
        comprobacionPrecio = entrada.next();
        precio = Float.parseFloat(comprobacionPrecio);
        tapiz1.setPrecio(precio);
        
        
        costoTotal = calculadora1.getCostoTotal();
        System.out.println("Su precio es de: "+costoTotal);
        
        
        
    }
}
