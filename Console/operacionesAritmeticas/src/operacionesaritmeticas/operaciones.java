package operacionesaritmeticas;

public class operaciones {
    float resultado = 0;
    float operacionAritmetica(int val1,int val2,int ope){
        switch(ope){
            case 1: System.out.println(" - Suma - ");
                    resultado = (val1+val2);
                    break;
            case 2: System.out.println(" - Resta - ");
                    resultado = (val1-val2);
                    break;
            case 3: System.out.println(" - Multiplicación - ");
                    resultado = (val1*val2);
                    break;
            case 4: System.out.println(" - División - ");
                    resultado = (val1/val2);
                    break;
            case 5: System.out.println(" - Residuo - ");
                    resultado = (val1%val2);
                    break;
                
        }
        
        return resultado;
    }
    
    String operacionRelacional(int val1,int val2, int ope){
        String mensaje = "";
        switch(ope){
            case 6: System.out.println(" - Menor que - ");
                    if(val1<val2){
                        mensaje = "El "+val1+" es menor al "+val2;
                    }
                    else{
                        mensaje = "El "+val1+" no es menor al "+val2;
                    }
                    break;
            case 7: System.out.println(" - Menor igual que - ");
                    if(val1<=val2){
                        mensaje = "El "+val1+" es menor o igual al "+val2;
                    }
                    else{
                        mensaje = "El "+val1+" no es menor o igual al "+val2;
                    }
                    break;
            case 8: System.out.println(" - Mayor que - ");
                    if(val1>val2){
                        mensaje = "El "+val1+" es mayor al "+val2;
                    }
                    else{
                        mensaje = "El "+val1+" no es mayor al "+val2;
                    }
                    break;
            case 9: System.out.println(" - Mayor igual que - ");
                    if(val1>=val2){
                        mensaje = "El "+val1+" es mayor o igual al "+val2;
                    }
                    else{
                        mensaje = "El "+val1+" no es mayor o igual al "+val2;
                    }
                    break;
        }
        
        return mensaje;
    }
    
    String operacionEquidad(int val1,int val2,int ope){
        String mensaje = "";
        switch(ope){
            case 10: System.out.println(" - Diferente - ");
                    if(val1!=val2){
                        mensaje = "El "+val1+" es diferente al "+val2;
                    }
                    else{
                        mensaje = "El "+val1+" no es diferente al "+val2;
                    }
                    break;
            case 11: System.out.println(" - Igual - ");
                    if(val1==val2){
                        mensaje = "El "+val1+" es igual al "+val2;
                    }
                    else{
                        mensaje = "El "+val1+" no es igual al "+val2;
                    }
                    break;
        }
        
        return mensaje;
    }
    
    boolean operacionLogica(int val1,int val2,int ope){
        boolean comprobacion = false;
        switch(ope){
            case 12:System.out.println(" - AND - ");
                    System.out.println("Se evaluará si ambos valores son mayores a 50");
                    comprobacion = ((50<val1) && (50<val2));
                    break;
            case 13:System.out.println(" - OR - ");
                    System.out.println("Se evaluará si un valores son mayores a 50");
                    comprobacion = ((50<val1) || (50<val2));
                    break;
        }
        
        return comprobacion;
    }
    
    String operacionCondicional(int val1,int val2,int ope){
        String mensaje = "";
        int suma;
        int caso;
        suma = val1+val2;
        switch(ope){
            case 14:System.out.println(" - if - ");
                    System.out.println("Se evaluará si la suma de los valores está entre 1 y 50");
                    if(suma>0 && suma<51){
                       mensaje = "Los valores están en el rango de 1 a 50";
                    }
                    else{
                       mensaje = "Los valores no están en el rango de 1 a 50";
                    }
                    break;
            case 15:System.out.println(" - switch - ");
                    System.out.println("Se evaluará si la suma de los valores está entre (1 a 50 = 1), (51 a 100 = 2) y (<1 ó >100 = 3) ");
                    if(suma>0 && suma<51){
                       caso = 1;
                    }
                    else if(suma>50 && suma<101){
                       caso = 2;
                    }
                    else{
                       caso = 3;
                    }
                     
                    switch(caso){
                        case 1: mensaje = "El caso es: "+caso+": Está entre el rango de 1 a 50";
                                 break;
                        case 2: mensaje = "El caso es: "+caso+": Está entre el rango de 51 a 100";
                                 break;
                        case 3: mensaje = "El caso es: "+caso+": Está entre el rango de <1 o >100";
                                 break;
                    }
                    break;
                     
        }
        
        return mensaje;
    }
    
    int iteraciones(int val1,int val2,int ope){
        int numeroIteraciones = 0;
        int suma = val1+val2;
        switch(ope){
            case 16:System.out.println(" - While - ");
                    System.out.println("Se saldrá del while hasta que el primer numero alcance la suma de uno en uno de la suma de ambos valores y se retornará el número de iteraciones");
                    while(val1<suma+1){
                        System.out.print(" "+val1);
                        val1++;
                        numeroIteraciones++;
                    }
                    break;
            case 17:System.out.println(" - do-while - ");
                    System.out.println("Se saldrá del do-while hasta la suma de ambos valores ya no sea mayor alsegundo termino, y se retornará el número de las iteraciones");
                    do{
                        System.out.print(" "+val2);
                        val2++;
                        numeroIteraciones++;
                    }while(val2<suma);
                    break;
            case 18:System.out.println(" - for - ");
                    System.out.println("El primer valor se repetirá las veces del segundo y se rtegresará el valor de las iteraciones");
                    for(int i=0;i<val2;i++){
                        numeroIteraciones++;
                        System.out.print(" "+val1);
                    }
                    break;
        }
        
        
        return numeroIteraciones;
    }
    
    
}
