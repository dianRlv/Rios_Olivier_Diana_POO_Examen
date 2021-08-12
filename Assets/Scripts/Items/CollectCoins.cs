/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - A Webdesign || Create a Score and collectable by usign Unity 3D  
    https://www.youtube.com/watch?v=kqkqxfRvXck&t=552s


Descripción General del Script: El código fue modificado para su uso en este ejercicio, pero se encuentra la linea original como nota.
                                Obtenido de un video de Youtube donde se explica la creacion de codigo para registrar colision entre 
                                player y coins asi como su registro en la interfaz de usuario por medio de un GUI.
                                
                                
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectCoins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//SCRIPT APLICABLE AL COIN
    //COLISIONES
    /*En la interfaz de Unity, al objeto "Coin" se le agrega el Collider que permitira su interaccion con este metodo.
    El cual permite identificar un trigger y de cierta forma colision entre el jugador y el coin */
    
    //Este metodo es para la colision entre el coin y el player donde...
    private  void OnTriggerEnter(Collider other) {
        if (other.name=="Player")   //Si el objeto con el que colisiona el coin tiene la etiqueta "Player"...
        {
            other.GetComponent<PlayerCollector>().points++; //Dentro del script PlayerCollector, aumenta el valor de los "point" de uno en uno (++)
            Destroy(gameObject);    //Entonces destruye el game objecto (Coin)
        }
    }
}
