using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
NOMBRE COMPLETO: Ríos Olivier Diana.
ASIGNATURA: Programación Orientada a Objetos.
NOMBRE Y NO. DE EJERCICIO: Ejercicio 2 - Codigo asignado para "Player" donde se declarán las variables de points y el texto de la interfaz de usuario.
Por medio del metodo Update se actualizara y mostraran los datos almacenados en coins, cuyo valor inicial es 0.

Ejercicio 5: Se declarara la variable para el item llaves, asi como un valor inicial, el txt de interfaz para indicar el numero de llaves, asi 
como un texto predeterminado.
*/


/* REFERENCIAS:
El código fue modificado para su uso en este ejercicio, pero se encuentra la linea original como nota. Obtenido de un video de Youtube
donde se explica la creacion de codigo para registrar colision entre player y coins asi como su registro en la interfaz de usuario por 
medio de un GUI. 
A Webdesign || Create a Score and collectable by usign Unity 3D : https://www.youtube.com/watch?v=kqkqxfRvXck&t=552s
*/


//Agregar la libreria UI de Unity para poder modificar / crear la interfaz de usuario
using UnityEngine.UI;

public class PlayerCollector : MonoBehaviour
{
    //Invocar a un Script
    BarraVida aumentoVida;

    //Varible publica de tipo int (porque son números), llamada points, vale inicialmente 0;
    public int points =0; //Valor inicial de los coins. 

    public int pocima=10; //Valor de las pocimas.

    public int key=0; //Variable para el item llave
       
     //Variable publica de tipo Text para el texto del score
    public Text txtScore;
    public Text txtKeys;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //en el texto txtScore, aparecera de forma predeterminada "Score: " y el valor de score
        txtScore.text="Score: " + points;  //Se ecuentra en Update porque debe actualizarce conforme el jugador colisione con el coin. 

        //En el txtKey, aparecera de forma predeterminada "Llaves:" y el número de llaves obtenido hasta ahora.
        txtKeys.text="Llaves: " + key; //En Updatw porque debe estar actualizandose.

    }


//LINEA ORIGINAL DEL VIDEO
    /*private void OnGUI() {
        Esta línea generará un text label, con estas dimenciones (20,20,200,40) y "Score :" es su contenido permanente estático.
        Lo que mostrará finalmente el label será el "Score:" + los points obtenidos. 
        //GUI.Label(new Rect(20,20,200,40),"Score : " + points);
        
        
    }*/



    


}
