using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
NOMBRE COMPLETO: Ríos Olivier Diana.
ASIGNATURA: Programación Orientada a Objetos.
NOMBRE Y NO. DE EJERCICIO: Ejercicio 3 - Creación del Array que almacenara a los enemigos
*/


/* REFERENCIAS:
El codigo tiene como referencias las notas y apuntes tomadas de la clase de Programacion de Objetos.
Rivadia UNI || Clase4_POO_AbstraccionesClaveyDiagramasUML: https://www.youtube.com/watch?v=KOuxVEQozog&list=PLIZd0XdWIMwo-s8lRr1S91DP7cFdE3Y7F&index=3
*/

public class ConstructorEnemigos : MonoBehaviour
{
    public SpawnEnemies[]nuevoEnemigo; //Base de datos y array
    void Awake() //AWAKE:Funciona un seg. antes que start. Invoca y carga el array
    {
        nuevoEnemigo=new SpawnEnemies[3];   //ARRAY DE 3 ELEMENTOS

        nuevoEnemigo[0]=new SpawnEnemies(1,"Mutant",20);
        nuevoEnemigo[1]=new SpawnEnemies(2,"Warrok",30);
        nuevoEnemigo[2]=new SpawnEnemies(3,"Skelet",10);
        
    }

}
