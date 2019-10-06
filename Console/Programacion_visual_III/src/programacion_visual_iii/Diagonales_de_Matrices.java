package programacion_visual_iii;

import java.util.Scanner;

public class Diagonales_de_Matrices {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        
        int limite,limite2;
        int matriz[][];
        int avance,suma1 = 0,suma2 = 0;
        int cont1=0,cont2=0,resta;
        
        System.out.println(" --- SUMA DE DIAGONALES DE UNA MATRIZ ---");
        do{
            System.out.print("Ingrese el limite de la matriz: ");
            limite = entrada.nextInt();
            
            if(limite<2){
                System.out.println("Error, no puede haber matrices menores a 3");
            }
        }while(limite<2);
        
        //Agregamos el limite denuestra matriz y la canti8da de los valores que habrá en ella
        matriz = new int[limite][limite];
        limite2 = limite;
        avance = 1;
        
        //Ingreso de valores
        System.out.println("Ingrese los datos de la matriz");
        for(int i=0;i<limite;i++){
            for(int j=0;j<limite2;j++){
                System.out.print("Ingrese el dato de la coordenada "+i+","+j+": ");
                matriz[i][j] = entrada.nextInt();
            }
        }
        
        //Impresion de la matriz
        System.out.println("\nSu matriz queda: ");
        System.out.print("[");
        for(int i=0;i<limite;i++){
            for(int j=0;j<limite2;j++){
                if(i==avance){
                    avance++;
                    System.out.print("]");
                    System.out.println("");
                    System.out.print("[");
                }
                System.out.print(matriz[i][j]+"  ");
            }
        }
        System.out.print("]");
        System.out.println("\n");
        
        //Realizamos la suma de las diagonales}
        cont1 = 0;
        cont2 = limite-1;
        for(int i=0;i<limite;i++){
            for(int j=0;j<limite;j++){
                //Suma 1
                if(i==j){
                    suma1 += matriz[i][j];
                }
                
                //Suma 2
                if(i==cont1 && j==cont2){
                    suma2 += matriz[cont1][cont2];
                    cont1=cont1+1;
                    cont2=cont2-1;
                }
            }
        }
        
        System.out.println("La primera suma de la diagonal es: "+suma1);
        System.out.println("La segunda suma de la diagonal es: "+suma2);
        resta = (suma1)-(suma2);
        if(resta<0){
            resta=resta*-1;
        }
        System.out.println("La diferencia de las diagonales es: "+resta);
        
    }
}
