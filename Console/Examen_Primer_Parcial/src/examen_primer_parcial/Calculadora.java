package examen_primer_parcial;

public class Calculadora {
    //Objetos para recibir datos de las clases
    Habitacion datosHabitacion = new Habitacion();
    Tapiz datosTapiz = new Tapiz(getTapiz());
    private float costoTotal;
    private float medidas;
    private float costo;
    
    Calculadora(float medidas, float costo){
        this.medidas = datosHabitacion.getCalcularArea();
        this.costo = datosTapiz.getCosto();
    }
    /*
    public PersonaDAO (ArrayList<Persona> Personas) {
		this.listasPersonas = Personas;

	}*/

    Calculadora() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
    public void setMedidas(float medidas){
        this.medidas = datosHabitacion.getCalcularArea();
    }
    
    public float getAncho(){
        return medidas;
    }
    
    public void setTapiz(float tapiz){
        this.costo = datosTapiz.getCosto();
    }
    
    public float getTapiz(){
        return costo;
    }
    
    public void setCostoTotal(float medidas, float costo){
        costoTotal = medidas * costo;
    }
    
    public float getCostoTotal(){
        return costoTotal;
    }
    
    
    
    
}
