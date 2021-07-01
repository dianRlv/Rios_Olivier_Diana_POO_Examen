using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
NOMBRE COMPLETO: Ríos Olivier Diana.
ASIGNATURA: Programación Orientada a Objetos.
NOMBRE Y NO. DE EJERCICIO: Ejercicio 1 - Creación de un controlador para personaje de juego de plataforma 3D con movimiento y animaciones.
DESCRIPCIÓN DEL SCRIPT: Creación de los datos y las variables para el personaje/ player.
*/


/* REFERENCIAS:
Los códigos fueron sacados de las grabaciones de clase, asi como las notas tomadas durante esta.
Rivadia UNI || Clase 7 POO Relaciones entre Objetos: https://www.youtube.com/watch?v=19x3_v5o-8s&list=PLIZd0XdWIMwo-s8lRr1S91DP7cFdE3Y7F&index=7
*/

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
