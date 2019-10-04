package programacion_visual_iii;

import java.io.*;
/*
import java.math.*;
import java.security.*;
import java.text.*;*/
import java.util.*;
/*
import java.util.concurrent.*;
import java.util.regex.*;*/

class Result {
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<Integer>> arr) {
    // Write your code here
        int limite=arr.size(),limite2=arr.size();
        int matriz[][];
        int suma1 = 0,suma2 = 0;
        int cont1,cont2,resta;

        //limite = entrada.nextInt();
        matriz = new int[limite][limite];
        
        //Ingreso de valores
        for(int i=0;i<arr.size();i++){
            for(int j=0;j<arr.size();j++){
                matriz[i][j] = arr.get(i).get(j);
            }
        }
        
        //Realizamos la suma de las diagonales
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
        
        resta = suma1-suma2;
        if(resta<0){
            resta=(resta)*(-1);
            return resta;
        }
        else{
            return resta;
        }
        
    }
}

public class Diagonal_Matriz_HackerRank {
     public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        //BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("Output")));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(("C:\\Users\\shavo\\Diagonal.txt")));
        
        int n = Integer.parseInt(bufferedReader.readLine().trim());

        List<List<Integer>> arr = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            String[] arrRowTempItems = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

            List<Integer> arrRowItems = new ArrayList<>();

            for (int j = 0; j < n; j++) {
                int arrItem = Integer.parseInt(arrRowTempItems[j]);
                arrRowItems.add(arrItem);
            }

            arr.add(arrRowItems);
        }

        int result = Result.diagonalDifference(arr);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
    
}
