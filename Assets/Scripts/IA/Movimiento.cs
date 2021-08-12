/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - Rivadia UNI || Clase 20 POO AI Basica
    https://www.youtube.com/watch?v=vm0eJ-0iPP8&list=PLIZd0XdWIMwo-s8lRr1S91DP7cFdE3Y7F&index=17

    -Video de YouTube - Rivadia UNI || Clase 21 POO IA Basica FSM
    https://www.youtube.com/watch?v=fyCxwS-8HQE&list=PLIZd0XdWIMwo-s8lRr1S91DP7cFdE3Y7F&index=19

    -Video de Youtube - Rivadia UNI || Clase 23 POO Daño Meele
    https://www.youtube.com/watch?v=SKYfBGZlaek&list=PLIZd0XdWIMwo-s8lRr1S91DP7cFdE3Y7F&index=22


Descripción General del Script: Codigo por medio del cual una clase constructora, permite la construccion, almacenamiento y ejecucion
                                de las animaciones que serán ejecutadar por el enemigo.
                                Estas se ejecutaran si los elementos "bool" o "tigger" estan en true o si las condiciones se cumplen.


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Creacion de una clase constructora con las animaciones (estados)
public enum EstadosAI 
{
    Idle,
    Running,
    
}
public class Movimiento : MonoBehaviour
{
    //Inicialización. Tambien puede hacerse por medio de start
    public EstadosAI estadoActual; 

    //VARIABLES
    //Permitiran trabajar y almacenar datos para la inteligencia articial
    public Transform target;
    public float Speedy;  
    public Animator IAController;
    public float distanciaExacta;
    Vector3 direccion;

    // Start is called before the first frame update
    void Start()
    {
        //Llama y define el estado actual . Running
        estadoActual=EstadosAI.Running; 

        //Invocacion del Animator
        IAController=GetComponent<Animator>(); 

        //Definiendo el estado actual . Idle
        estadoActual=EstadosAI.Idle ;
    }

    // Update is called once per frame
    void Update()
    {
        // Direccion = punto de llegada - punto de origen. Es una formula que nos sirve para ayudar a un objeto para decirle que direccion debe de seguir.
        Vector3 direccion = target.position - transform.position;
        //direccion.Normalize();
        //Debug.Log(direccion.magnitude);

        //El enemigo seguira con la "vista" al player
        transform.LookAt(target); 

        //SWITCH
        switch (estadoActual)
        {
            //Se invoca o manda a llamar a los Estados AI y la animacion para ser ejecutada.
            case EstadosAI.Idle:
           PlayAnim("Idle"); 
            break;

            //Se invoca o manda a llamar a los Estados AI y la animacion para ser ejecutada.
            case EstadosAI.Running:
            PlayAnim("Running");
            break;

            default:
            break;

        }

        //CONDICIONES
        //Condicion con la "formula" que permitira realizar la persecucion
        if (direccion.magnitude>distanciaExacta) 
        {
            //Llama a move para que se ejecute sobre direccion
            Move(direccion);
            //Llama al bool con la animacion "Corre" y lo declara como true (permite ejecutarse)
            ActivarAnimacionesBool("Corre", true);
             

        }
        // si ya alcanzaste al objetivo
        else if (direccion.magnitude<=distanciaExacta)
        {
            //Reproduce la animacion de ataque
            //PlayAnim("Ataque");
        }
        else
        {
            //Llama al bool con la animacion "Corre" y lo declara como false (detiene la reproduccion de la animacion)
            ActivarAnimacionesBool("Corre",false);
            //Activa la animacion de Idle
            PlayAnim("Idle");

        }
       
    }

//MOVIMIENTO por medio del Vector 3 direccion
   private void Move (Vector3 direccion)
    {
        this.transform.Translate (direccion.normalized * Speedy * Time.deltaTime,Space.World);
        //Animenemy.SetBool("Corre",true);
    }
    private void ActivarAnimacionesBool (string nombreAnimacion, bool valor)
    {
        IAController.SetBool(nombreAnimacion,valor);
    }

    private void PlayAnim(string nombreClip)
    {
        IAController.Play(nombreClip);
    }
}
