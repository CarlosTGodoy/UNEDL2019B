package operacionesaritmeticas;

import java.util.Scanner;

public class Test_operaciones {

    static int num1;
    static int num2;
    static int ope;
    static float resultado;
    static String mensaje;
    static boolean logico;
    static int iteraciones;

    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        operaciones op = new operaciones();
        System.out.println(" ----- Evaluación de operaciones ------ ");

        System.out.print("Ingrese el primer valor: ");
        num1 = entrada.nextInt();
        System.out.print("Ingrese el segundo valor: ");
        num2 = entrada.nextInt();
        
        //Menu
            System.out.println(" --- Menu de Operadores ---");
            System.out.println(" -Aritméticos- ");
            System.out.println("     +  _________ 1");
            System.out.println("     -  _________ 2");
            System.out.println("     *  _________ 3");
            System.out.println("     /  _________ 4");
            System.out.println("     %  _________ 5");
            System.out.println(" -Relaqcionales- ");
            System.out.println("     <  _________ 6");
            System.out.println("     <= _________ 7");
            System.out.println("     >  _________ 8");
            System.out.println("     >= _________ 9");
            System.out.println(" -Equidad- ");
            System.out.println("     != _________ 10");
            System.out.println("     == _________ 11");
            System.out.println(" -Lógicos- ");
            System.out.println("     && _________ 12");
            System.out.println("     || _________ 13");
            System.out.println(" -Condicionales- ");
            System.out.println("     if _________ 14");
            System.out.println("     switch _____ 15");
            System.out.println(" -Iteraciones- ");
            System.out.println("     while ______ 16");
            System.out.println("     do while  __ 17");
            System.out.println("     for ________ 18");
            System.out.println("Preciones 0 para salir");
            
        for(int i=0;i<5;i++){
            System.out.print("Ingrese el operador: ");
            ope = entrada.nextInt();
            
            System.out.println("\nResultados");
            
            if (ope >= 1 && ope <= 5) {
                System.out.println("Operador Aritmético");
                resultado = op.operacionAritmetica(num1, num2, ope);
                System.out.println(" = "+resultado);
                
            }
            else if(ope >= 6 && ope <=9){
                System.out.println("Operador Relacional");
                mensaje = op.operacionRelacional(num1, num2, ope);
                System.out.println(" = "+mensaje);
            }
            else if(ope >=10 && ope <=11){
                System.out.println("Operador de Equidad");
                mensaje = op.operacionEquidad(num1, num2, ope);
                System.out.println(" = "+mensaje);
            }
            else if(ope>=12 && ope<=13){
                System.out.println("Operadores Lógicos");
                logico = op.operacionLogica(num1, num2, ope);
                System.out.println("La expresion es: "+logico);
            }
            else if(ope>=14 && ope<=15){
                System.out.println("Operadores Condicionales");
                mensaje = op.operacionCondicional(num1, num2, ope);
                System.out.println(" = "+mensaje);
            }
            else if(ope>=16 && ope<=18){
                System.out.println("Operadores Repetitivos");
                iteraciones = op.iteraciones(num1, num2, ope);
                System.out.println(" = "+iteraciones);
            }
            else if(ope<0 || ope>16){
                System.out.println("Error: opción no valida");
            }
            else if (ope == 0) {
                System.out.println("Fin del programa");
                break;
                
            }
            i--;
        }

        

        

    }

}
