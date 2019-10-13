package palindromo;

import java.util.Scanner;

public class Palindromo {
    static String fraseNormal = "";
    static String fraseContraria = "";
    
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        char palabraXCaracter[];
         
        System.out.println(" --- Determinar un palindromo --- ");
        System.out.print("Ingrese la frase que desea comprobar: ");
        fraseNormal = entrada.nextLine()+"";
        fraseNormal = fraseNormal.replace(" ", "");
        palabraXCaracter = new char[fraseNormal.length()];
        
        int cont=palabraXCaracter.length-1;
        for(int i=0;i<fraseNormal.length();i++){
            palabraXCaracter[cont] = fraseNormal.charAt(i);
            cont--;
        }
        
        for(int i=0;i<fraseNormal.length();i++){
            fraseContraria += palabraXCaracter[i];
        }
        
        System.out.println("frase normal: "+fraseNormal);
        System.out.println("frase contraria: "+fraseContraria);
        
        boolean comprobacion = false;
        for(int i=fraseNormal.length();i>=0;i--){
            if(fraseNormal.equals(fraseContraria)){
                comprobacion = true;
            }
            else{
                comprobacion = false;
                break;
            }
            
        }
        
        if(comprobacion==true){
            System.out.println("Es palindromo");
            
        }
        else{
            System.out.println("No es palindromo");
        }
        
        //System.out.println("frase contraria: "+fraseContraria);
        
        
        
    }
    
}
