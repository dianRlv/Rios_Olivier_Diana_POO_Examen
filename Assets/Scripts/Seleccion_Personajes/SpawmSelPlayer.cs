/*
Nombre del Desarrollador: Diana Ríos Olivier.

Asignatura: Programacion Orientda a Objetos.

Profesor: Jouse Israel Rivas Díaz.

Fuente en la que base el script: 
    -Video de Youtube - Daniel Wayota || [Unity]: Pantalla de selección de personaje
    https://www.youtube.com/watch?v=iF-ORXh2UK0

    -Video de YOutube - GameDevTraum || { Ejemplo de un Menú de SELECCIÓN de PERSONAJES en Unity, Parte 1 } - Paquete Unity 📎
    https://www.youtube.com/watch?v=3xWqAoSXOkQ&t=226s



Descripción General del Script: Script que permitira definir un objeto con una posicion dentro de unity, parapoder spawmear el 
                                personaje seleccionado.


*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawmSelPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    // Solo usaremos Start
    void Start()
    {
        //Instanciar el player que esta en Player storage, player prefab; con la posicion y rotacion del spawner
        Instantiate(PlayerStorage.PlayerPrefab, this.transform.position,this.transform.rotation);

        //Luego de esto, destruir el spawm
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
