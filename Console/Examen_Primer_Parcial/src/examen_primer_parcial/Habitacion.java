package examen_primer_parcial;

public class Habitacion {
    private float ancho;
    private float largo;
    private float medidas;
    
    public void setAncho(float andcho){
        this.ancho = ancho;
    }
    
    public float getAncho(){
        return ancho;
    }
    
    public void setLargo(float largo){
        this.largo = largo;
    }
    
    public float getLargo(){
        return largo;
    }

    public void setMedidas(float medidas) {
        this.medidas = medidas;
    }
    
    public void setCalcularArea(float ancho, float largo){
        medidas = ancho*largo;
    }
    
    public float getCalcularArea(){
        return medidas;
    }
    
   
    
}
