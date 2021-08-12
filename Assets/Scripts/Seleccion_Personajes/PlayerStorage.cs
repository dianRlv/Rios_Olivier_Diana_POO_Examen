/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - Daniel Wayota || [Unity]: Pantalla de selección de personaje
    https://www.youtube.com/watch?v=iF-ORXh2UK0

    -Video de YOutube - GameDevTraum || { Ejemplo de un Menú de SELECCIÓN de PERSONAJES en Unity, Parte 1 } - Paquete Unity 📎
    https://www.youtube.com/watch?v=3xWqAoSXOkQ&t=226s



Descripción General del Script: Creacion de un Script que funcione como puente entre el selector de personaje y la escena donde
                                spawmeara el personaje selecionado en el menu de seleccion de personajes.


*/
using UnityEngine;

//Deja solamente el unity Engine

public static class PlayerStorage 
//Convertir a clase estática y quitar el Mono Behaviour
{
    /*No se usará ni "Start" ni "update" Pues este codigo será el puente para unir la 
      seleccion del personaje con el spawmeo escena del juego*/

      public static GameObject PlayerPrefab;
      //Referencia publica estatica de un game object (en este caso prefab)


}
