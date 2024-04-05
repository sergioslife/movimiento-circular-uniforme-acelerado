using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God : MonoBehaviour
{
    // Referencia al GameObject de la esfera
    public GameObject sphere;

    // Método Update que se llama en cada frame
    void Update()
    {
        // Obtener el componente MovimientoCircularUniformeAcelerado del GameObject de la esfera
        MovimientoCircularUniformeAcelerado script = sphere.GetComponent<MovimientoCircularUniformeAcelerado>();

        // Verificar si el componente existe
        if (script != null)
        {
            // Incrementar el tiempo del movimiento circular uniformemente acelerado basado en el tiempo transcurrido desde el último frame
            script.time += Time.deltaTime;
        }
    }
}

