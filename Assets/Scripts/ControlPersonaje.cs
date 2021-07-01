using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
NOMBRE COMPLETO: Ríos Olivier Diana.
ASIGNATURA: Programación Orientada a Objetos.
NOMBRE Y NO. DE EJERCICIO: Ejercicio 1 - Creación de un controlador para personaje de juego de plataforma 3D con movimiento y animaciones.
DESCRIPCIÓN DEL SCRIPT: Por medio de código crear los metódos y entrada del hardware (mouse) que permita el movimiento de un personaje 3D,
así como la asignacion de animaciones para el movimiento del personaje.
*/


/* REFERENCIAS:
Los códigos fueron sacados de las grabaciones de clase, asi como las notas tomadas durante esta.
Rivadia UNI || Clase 8 POO Controladores: https://www.youtube.com/watch?v=K-ZhYXvO_-c&list=PLIZd0XdWIMwo-s8lRr1S91DP7cFdE3Y7F&index=8 
*/


public class ControlPersonaje : MonoBehaviour
{   //Variables privadas pero editables.
    //SerializeFiel: Permite ingresarle valores a las variables sin dejar de ser privadas
    [SerializeField]
    private float velocidadMovimiento; //Variable para la velocidad de movimiento vertical del jugador
       
    [SerializeField]
    private float velocidadRotacion; //Velocidad con la que rotará el jugador


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
        //Declaración de Métodos
        MovimientoPersonaje(); //Método del movimiento del jugador
        RotacionPersonaje(); //Método de la Rotación del Jugador
        Salto();
        Abajo();
          
    }

    //MÉTODO DEL MOVIMIENTO DEL PERSONAJE
    private void MovimientoPersonaje()
    {
        //REGISTRA EL HARDWARE
        float vertical=Input.GetAxis("Vertical"); //controlador de Axis "Vertical"

        //Vector 3: para espacions 3d, 
        //Vector 3, nueva didección (x,y,z)
        Vector3 direction=new Vector3(0,0,vertical);  //Almacenar el Axis Vertical; lo convierte en una señal electrica

        //Estabilizar y Acelerar    //Lectura de cuadros por segundo y estabilización personal
        //La direccion sera el resultado de Time.deltaTime por velocidad de movimiento
        direction*=Time.deltaTime*velocidadMovimiento;

        //Transforma la traslacion en base a los valores de dirección
        this.transform.Translate(direction);

        
        
        //ANIMACIONES DEL JUGADOR
        /*Compara con un bool, que la direccion en z y su lectura vertical, no sea igual a 0. Posteriormente, despues de
         agregar un simbolo de interrogación, quiero que me retornes "true", en caso de estar activo o ser mayor que cero
         y "false" en caso de ser 0 */
        
        bool directionForward =direction.z != 0? true : false;

        animacionesPlayer.SetBool("Run", directionForward); //SetBool: Metodo estático
        //"(Usar el nombre exacto del parametro")
        //El personaje corre al pulsar las flechas

    
        
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
