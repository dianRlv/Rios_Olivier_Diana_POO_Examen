/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - Don Pachi || Tutorial - Coger items en Unity
    https://www.youtube.com/watch?v=oRHHQuyt3Ds&t=58s

    -Video de Youtube - DansterTv || Como recoger Objetos/Items en Unity (OnTriggerEnter) | Fácil y Sencillo
    https://www.youtube.com/watch?v=v6RUVH-Ehcc&t=41s
    

Descripción General del Script: Codigo generado para la colision del enemigo con el player, causando bajar cierto numero de vida y 
                                verlo reflejado instantateamente en la UI de barra de vida Player.


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColisionEnemigo : MonoBehaviour
{
    //Variable que almacena el daño del enemigo a colisionar
    private int dañoEnemigo =15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //SCRIPT APLICABLE AL ENEMIGO
    //COLISIONES
    /*En la interfaz de Unity, al objeto "enemy" se le agrega el Collider que permitira su interaccion con este metodo.
    El cual permite identificar un trigger y de cierta forma colision entre el jugador y el enemy */
    
    //Reconocer coliciones y evento trigger entre el jugador y el item
    private void OnTriggerEnter(Collider other) {
        //other. =Referencia al objeto con el que se esta colisionando
        if(other.tag=="Player") //Si el objeto con el que se colisiona tiene el tag de "Player"...
        {
            //Destroy(gameObject); //Destruyete. (El objeto Item)
            //Del componente barra vida, a la variable vida actual, sumale el valor de pocima.
            //other.GetComponent<BarraVida>().vidaActual-=dañoEnemigo;
            other.GetComponent<Player>().Vida-=dañoEnemigo;


        }
    }
}
