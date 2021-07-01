using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
NOMBRE COMPLETO: Ríos Olivier Diana.
ASIGNATURA: Programación Orientada a Objetos.
NOMBRE Y NO. DE EJERCICIO: Ejercicio 3 - Código por el cual, por medio de herencia y encapsulamiento se guardaran las variables de los
enemigos en un array, permitiendo que otro codigo interactue con este, carge los datos y ejecute.
*/


/* REFERENCIAS:
El codigo tiene como referencias las notas y apuntes tomadas de la clase de Programacion de Objetos.
Rivadia UNI || Clase4_POO_AbstraccionesClaveyDiagramasUML: https://www.youtube.com/watch?v=KOuxVEQozog&list=PLIZd0XdWIMwo-s8lRr1S91DP7cFdE3Y7F&index=3
*/



//HERENCIA Y ENCAPSULAMIENTO
public class Enemigo : MonoBehaviour
{
    public int EnemigoId;
    public string Nombre;

    public int Daño;

    public Transform[] spawPoint; //Variable publica de tipo transform que almacenara los datos de la variable spawPoint

    ConstructorEnemigos constEnemies; //Invocar al metodo (en otro Script) para arrastrar los datos del array 

    // Start is called before the first frame update
    void Start()
    {
        constEnemies =GameObject.FindObjectOfType<ConstructorEnemigos>();  //FORMA CORRECTA PARA INICIALIZAR OBJETOS UNICOS
        CargarDatos(EnemigoId); //La variable "playerid" será la que asigne datos a "cargar datos"


        InvokeRepeating ("Spamear",2,8);
        InvokeRepeating("Spawmear",6,14);
        InvokeRepeating("Spawmear",8,22);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ALGORITMO DE BUSQUEDA
    void CargarDatos(int id){
        for (int i = 0; i < constEnemies.nuevoEnemigo.Length; i++) //Cuerpo de la lectura
        //Quiero que mientras i sea - a la cantidad de obj en base de jugador, leas la asignación de valores
        {
            //si  ... en su base nuevo j, en el recorrido de i en playerid == al valor del parametro ...    
            if (constEnemies.nuevoEnemigo[i].EnemigoId==id)
                {
                    //Este algoritmo de busqueda me asignará los valore de nombre, vida y velocidad.
                    this.EnemigoId=constEnemies.nuevoEnemigo[i].EnemigoId;
                    this.Nombre=constEnemies.nuevoEnemigo[i].Nombre;
                    this.Daño=constEnemies.nuevoEnemigo[i].daño;
                }
                
            }
        }

    
    //NOTAS: Segun yo en la linea adapte todo para que buscara el elemento enemigo en el otro script pero no salio bien :c
    void EnemiesSpawmearA()
    {
        //Rango del spawmeo, basado en los puntos creados en interfaz, debe ser uno más que el numero de elementos (Similar al array)
        int i =Random.Range(0,2);
        //Instantiete: Es necesario para spawmear
                    //Localizar el elemento enemigo desde otro array
                                                        //Punto donde va a haces spawm
        Instantiate(constEnemies.GetComponent<Enemigo>(),spawPoint[i].position,transform.rotation);
    }

    void EnemiesSpawmearB()
    {
        int i =Random.Range(0,2);
        Instantiate(constEnemies.GetComponent<Enemigo>(),spawPoint[i].position,transform.rotation);
    }

    void EnemiesSpawmearC()
    {
        int i =Random.Range(0,2);
        Instantiate(constEnemies.GetComponent<Enemigo>(),spawPoint[i].position,transform.rotation);
    }


}
