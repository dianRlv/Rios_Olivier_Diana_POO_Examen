/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - Daniel Wayota || [Unity]: Pantalla de selección de personaje
    https://www.youtube.com/watch?v=iF-ORXh2UK0

    -Video de YOutube - GameDevTraum || { Ejemplo de un Menú de SELECCIÓN de PERSONAJES en Unity, Parte 1 } - Paquete Unity 📎
    https://www.youtube.com/watch?v=3xWqAoSXOkQ&t=226s



Descripción General del Script: Script que almacenara las cajas de seleccion de personaje y los prefabs dentro de "project" en Unity
                                los cuales permitiran que se pueda spawmear el personaje seleccionado en la escena deseada.
                                El codigo tambien permite la modificacion de interfaz de usuario, pues le da un feedback visual al 
                                jugador por medio de los botones y las cajas de seleccion de personajes (creadas dentro del hierarchy)
                                para identificar que esta selecionando el jugador.


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Añadir la biblioteca de Unity UI, para hacer uso de las interfaces de usuario
using UnityEngine.UI;

public class Selector : MonoBehaviour
{
    //VARIABLES PUBLICAS
    // Lista de los elementos o diferentes player a elegir y los prefabs

    public Image[] selectionBoxes;
    public GameObject[] prefabs;


    // Start is called before the first frame update
    void Start()
    {
        //Desactivar todos los cuadros de seleccion
        foreach(var img in this.selectionBoxes)
        {
            img.gameObject.SetActive(false);
        }

        //Activa inicialmente el jugador 0
        this.Select(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //METODOS
    //Método publico llamado "select", el cual recibira un indice
    //Este indice activara el cuadro de selecion y almacenar el prefab del jugador a spamear
    public void Select (int index)
    {
        
        //Desactivamos los cuadros de seleccion nuevamente
        foreach(var img in this.selectionBoxes)
        {
            img.gameObject.SetActive(false);
        }

        //Usamos el indice para activar el cuadro de seleccion nuevamente
        this.selectionBoxes[index].gameObject.SetActive(true);
        PlayerStorage.PlayerPrefab=this.prefabs[index];
    }
}
