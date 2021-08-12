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

public class MovimientoIA : MonoBehaviour
{

    //A donde quiero ir
    public Transform Target;

    //Velocidad con la que ira
    public float Velocidad;

    //Entrada del Animator
    public Animator animEnemigo;

    //Variable
    public float distanciaExacta;
    Vector3 direccion;

    // Start is called before the first frame update
    void Start()
    {
        //Leo el animator
        animEnemigo= GetComponent<Animator>();
        //animEnemigo es igual al componente de tipo animator
    }

    // Update is called once per frame
    void Update()
    {
        //Invocar el método
        Move();

        //Giro Enemigo
        transform.LookAt(Target);

        //CondicionesMov ();
        //nota: Extrañamente si cambio las condiciones fuera del mismo metodo que la formula, el personaje solo corre en su lugar, no hace nada mas
        
    }

    void Move(){ //MEter todo en un método

        //FORMULA
        /*Ayudar a un objeto a definir la direccion a la que se movera 
        (direccion: Punto a donde volteara)
        
        Esta formula obtiene un tercer vector "VECTOR INTERMEDIO" 
        
        Vector Intermedio: Saber cuanta distancia me queda para llegar a un punto*/

        //Direccion = Punto de Llegada - Punto de Origen
        Vector3 direccion=Target.position-transform.position;

        //NORMALIZAR EL VALOR DE DIRECCION **********OPCIONAL
        //direccion.Normalize();
        //Dara la posibilidad de ser presisos en la lectura, no decimales

        //El resultado es la distancia / magnitud del punto A ----> B

        //Debug.Log(direccion.magnitude); //Para el desarrollador
        // (direccion.magnitude) =  me devolvera la cantidad de espacios que hay entre uno y otro


        //sqrMagnitude: Más presiso que la magnitud normal, devuelve valores mpas exactos a lo que se le pide
         //Debug.Log(direccion.sqrMagnitude);

        //CONDICIONANTE
        //Si la magnitud es mayor a ...
        //if (direccion.magnitude>4) 
        if (direccion.magnitude>distanciaExacta) //PERSECUCION
        //if (direccion.sqrMagnitude<6) //PERSECUCION "sqrMagnitude"
        {
            

            //COMO REALIZARA LA TRASLACION HASTA ESE ESPACIO
            this.transform.Translate(direccion.normalized*Velocidad*Time.deltaTime,Space.World); 

            //ACTIVAR ANIMATOR
            animEnemigo.SetBool("Run_IA", true);

        }

        //Si ya alcanzaste al objetivo y la distancia es menor que la distancia de persecucion
        else if (direccion.magnitude<=distanciaExacta) //Si la direccion magnitud es menor que la distancia exacta
        {
            //Entonces manda a llamar al método PlayAnimations y reproduce "clip de animacion"
            PlayAnimations("Punch Combo");
        }
        else {
            PlayAnimations("Idle");
            animEnemigo.SetBool("Run_IA",false);
        }

    }

    //Metodo que pide como parámetro un string
    private void PlayAnimations(string nombreClip)
    {
        //Sin necesidad de una condicion compleja, se manda a reproducir el clip
        animEnemigo.Play(nombreClip);
    }


    }

    


