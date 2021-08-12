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

public class MovimientoIA1 : MonoBehaviour
{

    //A donde quiero ir
    public Transform Target;

    //Velocidad con la que ira
    public float Velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //FORMULA
        /*Ayudar a un objeto a definir la direccion a la que se movera 
        (direccion: Punto a donde volteara)
        
        Esta formula obtiene un tercer vector "VECTOR INTERMEDIO" 
        
        Vector Intermedio: Saber cuanta distancia me queda para llegar a un punto*/

        //Direccion = Punto de Llegada - Punto de Origen
        Vector3 direccion=Target.position-transform.position;

        //El resultado es la distancia / magnitud del punto A ----> B

        Debug.Log(direccion.magnitude); //Para el desarrollador
        // (direccion.magnitude) =  me devolvera la cantidad de espacios que hay entre uno y otro
    }
}
