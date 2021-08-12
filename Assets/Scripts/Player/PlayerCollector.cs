/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - A Webdesign || Create a Score and collectable by usign Unity 3D  
    https://www.youtube.com/watch?v=kqkqxfRvXck&t=552s


Descripción General del Script: Creacion de un script que actualice y muestre el estado actual del personaje.
                                La barra de vida en tiempo real, la cantidad de coins (score) que lleva, asi como
                                actualizarse instantaneamente por si llegara a haber algun evento; como el daño
                                recibido por algun enemigo, la regeneracion de vida, nuevas colisiones con coins,etc.

                                El script esta conectado con otro, pues en este se invoca al script "Baeea vida"


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        txtScore.text=": " + points;  //Se ecuentra en Update porque debe actualizarce conforme el jugador colisione con el coin. 

        //En el txtKey, aparecera de forma predeterminada "Llaves:" y el número de llaves obtenido hasta ahora.
        //txtKeys.text="Llaves: " + key; //En Updatw porque debe estar actualizandose.

    }


//LINEA ORIGINAL DEL VIDEO
    /*private void OnGUI() {
        Esta línea generará un text label, con estas dimenciones (20,20,200,40) y "Score :" es su contenido permanente estático.
        Lo que mostrará finalmente el label será el "Score:" + los points obtenidos. 
        //GUI.Label(new Rect(20,20,200,40),"Score : " + points);
        
        
    }*/



    


}
