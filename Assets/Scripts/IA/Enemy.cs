/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - GameDev con Hektor || Enemigos que te persiguen (IA Simple) | Tutorial Unity 5
    https://www.youtube.com/watch?v=G60le64vmM4&t=44s

    -Video de YouTube - Profe TIC || Curso de Unity - Instanciar enemigos en posiciones aleatorias
    https://www.youtube.com/watch?v=EciIoFj4L68

    -Video de Youtube - Pixelpro || Curso Unity 5 - 3.4 enemigo seguimiento
    https://www.youtube.com/watch?v=qjImGdJ8fug&t=582s
    

Descripción General del Script: Codigo para la creacion de radares y detonación de animaciónes para el enemigo.
                                Donde inicialmente se mostrará en pantalla un enemigo en estado idle, y al estar el
                                player dentro de su rango , este comenzará a perseguirlo y causarle daño al colisionar.
                                Si el player logra salir del rango del enemigo, este volverá a su posición inicial, 
                                dejando asi al player en paz.


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Variables para gestionar el radio de vision y velocidad
    public float VisionRadius;
    public float SpeedE;

    //Variable para guardar al jugador
    GameObject player;

    //Variable para guardar la posicion Inicial
    Vector3 initialPosition;

    //Entrada del Animator
    public Animator animEnemigo;




    // Start is called before the first frame update
    void Start()
    {

        //Recuperamos los datos del jugador por medio del tag "Player"
        player=GameObject.FindGameObjectWithTag("Player");

        //Guardamos nuestra posicion Inicial
        initialPosition=transform.position;

        //Leo el animator
        animEnemigo= GetComponent<Animator>();
        //animEnemigo es igual al componente de tipo animator
    }

    // Update is called once per frame
    void Update()
    {
        //Por defecto nuestro objetivo siempre será la posicion inicial
        Vector3 target=initialPosition;

        //Pero si la distancia del jugador es menor es menor que el radio de vision, el objetivo será el
        float dis =Vector3.Distance(player.transform.position,transform.position);
        if (dis<VisionRadius)target=player.transform.position;

        //Finalmente movemos al enemigo a la direccion de su target
        float fixedSpeed=SpeedE*Time.deltaTime;
        transform.position=Vector3.MoveTowards(transform.position,target,fixedSpeed);
        

        //Y debug con linea
        Debug.DrawLine(transform.position,target,Color.green);


        //SEGUIR CON LA VISTA AL PLAYER
        transform.LookAt(target); 


        //ACTIVAR ANIMATOR

        /*if ((dis<=VisionRadius) || (target==initialPosition))
        {
            animEnemigo.SetBool("Run_IA", true);
            //target=player.transform.position;
        }*/
        /*else
        {
            animEnemigo.SetBool("Run_IA",false);
        }*/

        if (target==initialPosition)
        {
            animEnemigo.SetBool("Run_IA",false);
        }
        else
        {
            animEnemigo.SetBool("Run_IA",true);
        }
        

    }

    void OnDrawGizmos() {
        Gizmos.color=Color.yellow;
        Gizmos.DrawWireSphere(transform.position,VisionRadius);
        //animEnemigo.SetBool("Run_IA", true);
        
    }

 

}
