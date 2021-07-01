using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
NOMBRE COMPLETO: Ríos Olivier Diana.
ASIGNATURA: Programación Orientada a Objetos.
NOMBRE Y NO. DE EJERCICIO: Ejercicio 3 - Crear por medio del codigo un contenedor o array que almacene los enemigos y los valores de sus variables. 
Y usando Random.Range hacer que aparezcan en sitios distintos de forma aleatoria.
*/


/* REFERENCIAS:
El codigo tiene como referencias las notas y apuntes tomadas de la clase de Programacion de Objetos.
Asi como de las siguientes ligas:
JuaniDev || Como hacer un spawn de enemigos en Unity 2021 3D: https://www.youtube.com/watch?v=5LjwwKmxuWk
Juan Pujol || Prefab en Unity para crear un respawn de enemigos - Creador de Videojuegos 11: https://www.youtube.com/watch?v=GHW9bpX7n_Q
*/

[SerializeField]
public class SpawnEnemies //Al momento de quitarle la herencia "monobehaviour" se convierte en una clase tradicional de C#
{
    //Variables publicas del enemigo
    public int EnemigoId;
    public string Nombre;

    public int daño;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    //MÉTODO CONSTRUCTOR
    public SpawnEnemies (int idE,string Nom , int damage){
        //Al constructor se le darán parámetros para poder asignar argumentos ()
        //PARÁMETROS:Elementos que me van a pedir los métodos para poder hacer funcionar su acción / evento

        this.EnemigoId=idE;
        this.Nombre=Nom;
        this.daño=damage;


    }

    
}
