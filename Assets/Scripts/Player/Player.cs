/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - Rivadia UNI || Clase 7 POO Relaciones entre Objetos
    https://www.youtube.com/watch?v=19x3_v5o-8s&list=PLIZd0XdWIMwo-s8lRr1S91DP7cFdE3Y7F&index=7


Descripción General del Script: Creación de un controlador para personaje de juego de plataforma 3D con movimiento y animaciones.
                                Creación de los datos y las variables para el personaje/ player. 
                                El código principal fue obtenido de las grabaciones de la clase de programación de objetos, 
                                así como adaptado a las necesidades segun el juego /personaje.        

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//HERENCIA Y ENCAPSULAMIENTO
public class Player : MonoBehaviour
{
    /* Tipo: Public - Visible y Editable  / Private: Invisible, no es editable
        Tipo de dato: int / string / float / bool
        Variables: Nombre ...   */

    public int PlayerId;
    public string Nombre;
    public int Vida;

    //[SerializeField] //La variable sigue siendo privada pero es editable
    //private int score;

    //[SerializeField] //La variable sigue siendo privada pero es editable
    //private float itemPocima;

       
    // Update is called once per frame
    void Update()
    {
        
    }
}
