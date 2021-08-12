/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - Rivadia UNI || Clase 8 POO Controladores
    https://www.youtube.com/watch?v=K-ZhYXvO_-c&list=PLIZd0XdWIMwo-s8lRr1S91DP7cFdE3Y7F&index=8

    -Video de Youtube - Rivadia UNI ||Clase 18 Blend Tree
    https://www.youtube.com/watch?v=nXlD6lFj1cU&list=PLIZd0XdWIMwo-s8lRr1S91DP7cFdE3Y7F&index=15

    -Video de YouTube - Rivadia UNI ||Clase 19 Animator Layers
    https://www.youtube.com/watch?v=nXlD6lFj1cU&list=PLIZd0XdWIMwo-s8lRr1S91DP7cFdE3Y7F&index=15

    -Video de YOutube - Profe TIC || Curso de Unity - Límites de movimiento del jugador
    https://www.youtube.com/watch?v=PdYb5-XDOwc&t=253s

    -Video de Youtube - Dima Kitsune || Unity2D 009 Límites Player
    https://www.youtube.com/watch?v=2whUJHIZS_I&t=356s


Descripción General del Script: El código principal fue obtenido de las grabaciones de la clase de programación de objetos, 
                                así como adaptado a las necesidades segun el juego /personaje.
                                Con el control de personaje realizado anteriormente, se generará un blend tree y capas que 
                                permita crear la caminata hacia atras, definir los parametros para que el personaje ataque, 
                                corrra, entre otros.

                                Tambien Gracias a las condicionantes generadas a partir de los ejes y la posicion que puede tener
                                el player, se generaron limites dentro del juego, evitando que el jugador corra infinitamente o que
                                salga volando a lugares desconocidos dentro del juego.
                                

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{   //Variables privadas pero editables.
    //SerializeFiel: Permite ingresarle valores a las variables sin dejar de ser privadas
    [SerializeField]
    private float velocidadMovimiento; //Variable para la velocidad de movimiento vertical del jugador
       
    [SerializeField]
    private float velocidadRotacion; //Velocidad con la que rotará el jugador

    //LAYERS
    public bool StandAttack;

    //ANIMACIONES PERSONAJE
    Animator animacionesPlayer;
    //Awake: Invocar al método "animacionesPlayer" a que lea el componente "Animator"
    void Awake() {
        animacionesPlayer=GetComponent<Animator>();
    } 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

//DELIMITAR MOVIMIENTO**********************************

    //LIMITES HORIZONTALES
        //si la posicion del eje x es > o igual a 35 entonces...
        if(transform.position.x >= 35)
        {
            //Regresa al player a la posicion 34 sobre el eje x, el eje Y y Z, se quedaran en la posicion actual.
            transform.position=new Vector3 (34,transform.position.y,transform.position.z);
        }

        //si la posicion del eje x es < o igual a -35 entonces...
        if(transform.position.x <= -35)
        {
            //Regresa al player a la posicion -34 sobre el eje x, el eje Y y Z, se quedaran en la posicion actual.
            transform.position=new Vector3 (-34,transform.position.y,transform.position.z);
        }

    //LIMITES VERTICALES
        //si la posicion del eje z es > o igual a 35 entonces...
        if(transform.position.z >=35)
        {
            //Regresa al player a la posicion 34 sobre el eje z, el eje Y y X, se quedaran en la posicion actual.
            transform.position=new Vector3 (transform.position.x,transform.position.y,34);
        }

        //si la posicion del eje z es < o igual a -35 entonces...
        if(transform.position.z <=-35)
        {
            //Regresa al player a la posicion -34 sobre el eje z, el eje Y y X, se quedaran en la posicion actual.
            transform.position=new Vector3 (transform.position.x,transform.position.y,-34);
        }

//*****************************************************


        //Declaración de Métodos
        MovimientoPersonaje(); //Método del movimiento del jugador
        RotacionPersonaje(); //Método de la Rotación del Jugador
        Salto();
        Abajo();

        //ANIMATOR LAYERS
        if(Input.GetMouseButtonDown(1)){    //Si presiono el boton derecho del mouse, se verificara si el stand attack esta en true or false
            if (StandAttack==false)         //si esta en falso, 
            StandAttack=true;               //lo va a pasar a verdadero, y si esta en verdadero
            else                            
            StandAttack= false;             //lo va a pasar a falso
        }
        
        //Activar clip de animación de ataque
       if (Input.GetMouseButtonDown(0)) //Verifica con el boton izquierdo del mouse si esta activo el attack
        Attack();
        StandingAttack(StandAttack); //Estoy llamando al metodo heredado de standing attack, stand attack 
          
    }

    //MÉTODO DEL MOVIMIENTO DEL PERSONAJE
    private void MovimientoPersonaje()
    {
        //REGISTRA EL HARDWARE
        float vertical=Input.GetAxis("Vertical"); //controlador de Axis "Vertical"
        float horizontal=Input.GetAxis("Horizontal"); //controlador de Axis "Horizontal"

        //Vector 3: para espacions 3d, 
        //Vector 3, nueva didección (x,y,z)
        Vector3 direction=new Vector3(horizontal,0,vertical);  //Almacenar el Axis Vertical; lo convierte en una señal electrica

        //Estabilizar y Acelerar    //Lectura de cuadros por segundo y estabilización personal
        //La direccion sera el resultado de Time.deltaTime por velocidad de movimiento
        //direction*=Time.deltaTime*velocidadMovimiento;

        //NORMALIZAR UN VALOR
        //direction.Normalize(); //Esto obligara a que no existan decimales

        //Transforma la traslacion en base a los valores de dirección
        //this.transform.Translate(direction);

        this.transform.Translate(direction.normalized*velocidadMovimiento*Time.deltaTime);

        //B L E E N D   T R E E

        //Invoca al animator del player, que trabaje con un float llamado "Velocidad" el cual se irá sobre la dirección z * por la vel movimiento
        
        animacionesPlayer.SetFloat("Velocidad", direction.z);
        animacionesPlayer.SetFloat("VelocidadLateral", direction.x);
        
        //                                                  Que lea la magnitud total
        //animacionesPlayer.SetFloat("Velocidad", direction.magnitude); //Magnitud: Me devolvera el valor máximo
 
        
    //ANIMACIONES DEL JUGADOR
        /*Compara con un bool, que la direccion en z y su lectura vertical, no sea igual a 0. Posteriormente, despues de
         agregar un simbolo de interrogación, quiero que me retornes "true", en caso de estar activo o ser mayor que cero
         y "false" en caso de ser 0 */
        
    //bool directionForward =direction.z != 0? true : false;

    //animacionesPlayer.SetBool("Run", directionForward); //SetBool: Metodo estático
        //"(Usar el nombre exacto del parametro")
        //El personaje corre al pulsar las flechas 
    }

//CAPA DE ATAQUE 

    //Protected: Permite que puedan ser heredados y controlador por otro script
    protected void StandingAttack (bool a){ //Metodo para bool para llamar al animacion Player "StandAttack"
        animacionesPlayer.SetBool("StandAttack" ,a);
    }

    protected void Attack(){  //Método trigger para llamar al animacion player "Attack"
        animacionesPlayer.SetTrigger("Attack"); 
        
    }



    //MÉTODO PARA LA ROTACIÓN DEL PERSONAJE
    private void RotacionPersonaje()
    {
        //Registra el movimiento que hace el mouse sobre el eje x
        //El float h_Rotacion = a la entrada de movimiento del mouse sobre el eje x
        float h_Rotacion=Input.GetAxisRaw("Mouse X");

        //Almacena la rotacion en el eje y, el cual permite que el jugador pueda girar
        Vector3 Rotacion_h=new Vector3(0,h_Rotacion,0);

        //Rotacion_h es igual a la multiplicacion de time.deltaTime por la velocidad de rotacion.
        //Que tanto rotara en base a al velocidad y tiempo
        Rotacion_h*=Time.deltaTime*velocidadRotacion;

        //Transforma la rotacion del player en base a los valores existentes dentro de la variable Rotacion_h
        this.transform.Rotate(Rotacion_h);

    }

    //  ANIMACIONES 
        private void Salto() //El personaje Salta
        {
            if (Input.GetKeyDown(KeyCode.Space)) //Si se presiona la tecla espacio
            {
                animacionesPlayer.SetTrigger("Jump"); //Activa el trigger "Jump"
            }
        }

        private void Abajo() //El personaje se Agacha
        {
            if (Input.GetKeyDown(KeyCode.X)) //Si se presiona la tecla X
            {
                animacionesPlayer.SetTrigger("Down"); //Activa el trigger "Down"
            }
        }


}
