using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCircularUniformeAcelerado : MonoBehaviour
{
    // Velocidad inicial de rotaci�n circular
    public float initialVelocity = 2.0f;

    // Aceleraci�n angular de la rotaci�n circular
    public float angularAcceleration = 1.0f;

    // Tiempo transcurrido desde el inicio del movimiento
    public float time = 0.0f;

    // Radio del c�rculo en el que se mover� el objeto
    public float radius = 5.0f;

    // Posici�n actual del objeto en el c�rculo
    private Vector3 position;

    void Start()
    {
        // Calcula la posici�n inicial basada en el tiempo y el radio
        position = new Vector3(
            radius * Mathf.Cos(initialVelocity * time),
            radius * Mathf.Sin(initialVelocity * time),
            0.0f
        );

        // Establece la posici�n inicial del objeto
        transform.position = position;
    }

    void Update()
    {
        // Incrementa el tiempo basado en el tiempo transcurrido desde el �ltimo frame
        time += Time.deltaTime;

        // Calcula la nueva posici�n basada en el tiempo, el radio, la velocidad inicial y la aceleraci�n angular
        position = new Vector3(
            radius * Mathf.Cos(initialVelocity * time + 0.5f * angularAcceleration * time * time),
            radius * Mathf.Sin(initialVelocity * time + 0.5f * angularAcceleration * time * time),
            0.0f
        );

        // Actualiza la posici�n del objeto
        transform.position = position;
    }
}
