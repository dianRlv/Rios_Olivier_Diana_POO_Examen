/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - LuisCanary || Start MENU en Unity /Main Menu/ Facil y Sencillo para 3D y 2D
     https://www.youtube.com/watch?v=zGvM2pM0QzA&t=358s

    -Video de Youtube - David Guevara || Unity 2018 - Crear Boton de Salir - Create a Quit Button - DG
    https://www.youtube.com/watch?v=S1qg35nkySE

    -Video de Youtube - GameDevTraum || { Botón para SALIR del juego en Unity } - Tips rápidos para Unity
    https://www.youtube.com/watch?v=89Z_rIFetus

Descripción General del Script: Codigo corto para colocarlo individualmente a los botones, los cuales con un "On click Event", 
                                pérmitiá cerrar la aplicación y cargar la escena.


*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Libreria para la gestion de escenas en unity, sin ellas no se accesar al cambio entre ellas
using UnityEngine.SceneManagement;


public class Menu_Principal : MonoBehaviour
{
    //no se necesita Start ni Update
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Método publico para la escena del juego
    public void EscenaSeleccionPersonaje()
    {
        //Scene Manager, cargar esena con el nombre ("nombre de la escena")
        SceneManager.LoadScene("Seleccion_Personaje");
    }
    
    //Método público para Salir
    public void Salir()
    {
        Application.Quit(); //Se usa Aplication porque se esta ordenando cerrar la aplicacion dle juego
    }
    


}

