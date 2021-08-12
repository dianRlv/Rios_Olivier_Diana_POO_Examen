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
                                pérmitiá cargar cada una de las escenas del juego segun el boton pulsado.


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Libreria para la gestion de escenas en unity
using UnityEngine.SceneManagement;

public class Menu_Personajes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PersonajeElegidoP1() //Metodo con nombre identificable
    {
        //Scene Manager, cargar esena con el nombre ("nombre de la escena")
        SceneManager.LoadScene("Bloom_P1"); //PERSONAJE 1
         
    }

    public void PersonajeElegidoP2()
    {
        //Scene Manager, cargar esena con el nombre ("nombre de la escena")
        SceneManager.LoadScene("Pinky_P2");//PERSONAJE 2
    }

    public void PersonajeElegidoP3()
    {
        //Scene Manager, cargar esena con el nombre ("nombre de la escena")
        SceneManager.LoadScene("Darik_P3");//PERSONAJE 3
    }

    public void Regresar()
    {
        SceneManager.LoadScene("Menu_Principal"); //Si se pulsa este boton, se regresará al menu Principal
    }

    
}
