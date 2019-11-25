package Herencia;

public class Padres {
    private String colorOjos;
    private String tipoCabello;
    private String colorCabello;
    private String colorPiel;
    private float altura;
    
    public Padres(String colorOjos, String tipoCabello, String colorCabello, String colorPiel, float altura){
        this.colorOjos = colorOjos;
        this.tipoCabello = tipoCabello;
        this.colorCabello = colorCabello;
        this.colorPiel = colorPiel;
        this.altura = altura;
        
    }

    public String getColorOjos() {
        return colorOjos;
    }

    public String getTipoCabello() {
        return tipoCabello;
    }

    public String getColorCabello() {
        return colorCabello;
    }

    public String getColorPiel() {
        return colorPiel;
    }

    public float getAltura() {
        return altura;
    }
    
    //Metodos
    protected void Caracter(){
        System.out.println("- Tiene caracter fuerte");
    }
    
    protected void Risa(){
        System.out.println("- Risa del papá");
    }
    
    protected void GestoBoca(){
        System.out.println("- Torcer la boca cuando está pensado");
    }
}
