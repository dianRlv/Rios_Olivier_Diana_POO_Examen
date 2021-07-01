using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
NOMBRE COMPLETO: Ríos Olivier Diana.
ASIGNATURA: Programación Orientada a Objetos.
NOMBRE Y NO. DE EJERCICIO: Ejercicio 2 - Por medio de Elementos Ui y con la libreria de Unity.UI, generar un marcador de vida; en este caso una Barra
de vida, la cual permitira retroalimentar al jugador sobre su estado actual dentro del juego.
    Ejercicio 4- Script que almacena los datos de la vida del jugador y la relacion con la barra de vida; retroalimenta al usuario 
    por medio de la interfaz
*/


/* REFERENCIAS:
El código y creación de la barra de vida fue sacado de un video de Youtube, donde se explica la creación de una barra de vida y el código de esta.
LuisCanary || Como hacer una BARRA de VIDA en Unity: https://www.youtube.com/watch?v=uytdBD7xDrc
*/


//Agregar la libreria de UI, para poder modificar /crear interfaz de usuario
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    //Generar una variable pública de tipo image, llamada "barraVida"
    public Image barraVida;

    //Invocar un script
    Player playerData;

    //Variables publicas de tipo float que definirán la vida actual del player y el máximo de vida que puede tener.
    public float vidaActual;
    public float vidaMáxima;


    //NO SE NECESITA DEL MÉTODO START
    // Start is called before the first frame update
    void Start()
    {
        //Enparentar playerdata con el componente player
        playerData=GetComponentInParent<Player>();
        vidaActual=playerData.Vida; //Donde vida Actual (Script Barra Vida) es igual a la vida del player data (Script Player)
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaActual=playerData.Vida; //Actualiza los cambios en la vida del player (Script Player: que es la base de datos y el Script Barra: Interface de Usuario)

        

        //En la barra vida, usa el fill amount, dividiendo la vida actual de la máxima.
        /*fillAmount: Propiedad de un Image, activada desde el inspector de UNITY, el cual permite
        un desplamiento de tipo Horizontal, vertical o 360°; En este caso dará el efecto de la reduccion
        o aumento de vida del jugador*/

        //Dpendiendo de la vida que se tenga el "fillAmount" sera mayor o menor
        barraVida.fillAmount=vidaActual/vidaMáxima;
        
    }


}
