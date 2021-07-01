using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
NOMBRE COMPLETO: Ríos Olivier Diana.
ASIGNATURA: Programación Orientada a Objetos.
NOMBRE Y NO. DE EJERCICIO: Ejercicio 4 - Scrip para generar las colisiones del jugador con el enemigo. Asi como las variables necesarias 
del daño que este otorgará al jugador y se vera reflejado en la pantalla gracias a la barra de vida

*/


/* REFERENCIAS:
Los códigos se basaron el el codigo anteriormente creado de coins, pues tambien se destruye al chocar, solo que a diferencia del coin que
forma parte del score, este restaura la vida del personaje.
*/
public class ColisionEnemigo : MonoBehaviour
{
    //Variable que almacena el daño del enemigo a colisionar
    private int dañoEnemigo =25;

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
            Destroy(gameObject); //Destruyete. (El objeto Item)
            //Del componente barra vida, a la variable vida actual, sumale el valor de pocima.
            //other.GetComponent<BarraVida>().vidaActual-=dañoEnemigo;
            other.GetComponent<Player>().Vida-=dañoEnemigo;


        }
    }
}
