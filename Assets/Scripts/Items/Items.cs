/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - A Webdesign || Create a Score and collectable by usign Unity 3D  
    https://www.youtube.com/watch?v=kqkqxfRvXck&t=552s

    -Video de YouTube - Don Pachi || Tutorial - Coger items en Unity
    https://www.youtube.com/watch?v=oRHHQuyt3Ds&t=58s

    -Video de YouTube - DansterTv || Como recoger Objetos/Items en Unity (OnTriggerEnter) | Fácil y Sencillo
    https://www.youtube.com/watch?v=v6RUVH-Ehcc&t=41s


Descripción General del Script: El código fue modificado para su uso en este ejercicio, pero se encuentra la linea original como nota.
                                Obtenido de un video de Youtube donde se explica la creacion de codigo para registrar colision entre 
                                player y coins asi como su registro en la interfaz de usuario por medio de un GUI.
                                Los códigos se basaron el el codigo anteriormente creado de coins, pues tambien se destruye al chocar, solo que a diferencia del coin que
                                forma parte del score, este restaura la vida del personaje.

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Items : MonoBehaviour
{

    private int Pocima=10;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Reconocer coliciones y evento trigger entre el jugador y el item
    private void OnTriggerEnter(Collider other) {
        //other. =Referencia al objeto con el que se esta colisionando
        if(other.tag=="Player") //Si el objeto con el que se colisiona tiene el tag de "Player"...
        {
            Destroy(gameObject); //Destruyete. (El objeto Item)
            //Del componente barra vida, a la variable vida actual, sumale el valor de pocima.
            //other.GetComponent<BarraVida>().vidaActual+=Pocima;
            other.GetComponent<Player>().Vida+=Pocima;


        }
    }
}
