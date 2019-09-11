package recorridomatriz;

import java.util.Scanner;

public class RecorridoMatriz {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        
        //int matriz[][] = new int[4][4];
        int [][] matriz= {{1,3,5,7},{4,7,9,7},{2,6,8,0},{2,4,5,2}};
        
        System.out.println(" --- MATRIZ, EXAMEN DIAGNOSTICO 1 --- ");
        
        for(int i=0;i<4;i++){
            if(i==0 || i==2){
                for(int j=0;j<4;j++){
                    System.out.print(matriz[j][i]+" ");
                }
            }
            else if(i==1 || i==3){
                for(int j=3;j>-1;j--){
                    System.out.print(matriz[j][i]+" ");
                }
            }
        }
        
    }
}
