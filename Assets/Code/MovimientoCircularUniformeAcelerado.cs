using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCircularUniformeAcelerado : MonoBehaviour
{
    // Velocidad inicial de rotación circular
    public float initialVelocity = 2.0f;

    // Aceleración angular de la rotación circular
    public float angularAcceleration = 1.0f;

    // Tiempo transcurrido desde el inicio del movimiento
    public float time = 0.0f;

    // Radio del círculo en el que se moverá el objeto
    public float radius = 5.0f;

    // Posición actual del objeto en el círculo
    private Vector3 position;

    void Start()
    {
        // Calcula la posición inicial basada en el tiempo y el radio
        position = new Vector3(
            radius * Mathf.Cos(initialVelocity * time),
            radius * Mathf.Sin(initialVelocity * time),
            0.0f
        );

        // Establece la posición inicial del objeto
        transform.position = position;
    }

    void Update()
    {
        // Incrementa el tiempo basado en el tiempo transcurrido desde el último frame
        time += Time.deltaTime;

        // Calcula la nueva posición basada en el tiempo, el radio, la velocidad inicial y la aceleración angular
        position = new Vector3(
            radius * Mathf.Cos(initialVelocity * time + 0.5f * angularAcceleration * time * time),
            radius * Mathf.Sin(initialVelocity * time + 0.5f * angularAcceleration * time * time),
            0.0f
        );

        // Actualiza la posición del objeto
        transform.position = position;
    }
}
