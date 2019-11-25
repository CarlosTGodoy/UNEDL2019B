package Herencia;

public class Hijo extends Padres{
    private String OjosGrandes;
    private String orejasChicas;
    
    public Hijo(String colorOjos, String tipoCabello, String colorCabello, String colorPiel, float altura, String ojosGrandes, String orejasChicas){
        //Con super le decimos a java cuales de los atributos está heredando de la clase padre.
        //Esto sirva para ya no inicializarlas de nuevo
        super(colorOjos,tipoCabello,colorCabello,colorPiel,altura);
        
        this.OjosGrandes = ojosGrandes;
        this.orejasChicas = orejasChicas;
    }
    
    public void Mostrar(){
        System.out.println("Los atributos que heheredado de mis padres");
        System.out.println("- Color de ojos: "+getColorOjos()+
                           "\n- Tipo de cabello: "+getTipoCabello()+
                           "\n- Color de cabello: "+getColorCabello()+
                           "\n- Color de piel: "+getColorPiel()+
                           "\n- Altura: "+getAltura());
        
        System.out.println("\nMis propios atributos");
        System.out.println("- Ojos grandes: "+OjosGrandes+
                           "\n- Orejas chicas: "+orejasChicas);
        
    }
    
    public void Expresion(){
        System.out.println("- Se expresa de manera seria y alegre");
    }
    
    public void FormaDeTrabajo(){
        System.out.println("- Tiene orden en lo que hace (tareas y trabajo)");
    }
    
    public void Disciplina(){
        System.out.println("- Tiene una gran disciplina");
    }
    
}