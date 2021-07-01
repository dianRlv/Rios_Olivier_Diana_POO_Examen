using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
NOMBRE COMPLETO: Ríos Olivier Diana.
ASIGNATURA: Programación Orientada a Objetos.
NOMBRE Y NO. DE EJERCICIO: Ejercicio 2 - Crear un codigo para asignar los valores al item Pocima, el cual restaura la vida del jugador cuando 
colisionan entre ellos.

*/


/* REFERENCIAS:
Los códigos se basaron el el codigo anteriormente creado de coins, pues tambien se destruye al chocar, solo que a diferencia del coin que
forma parte del score, este restaura la vida del personaje.
*/

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
