using UnityEngine;

public class FaceToward12 : MonoBehaviour
{
    public Transform cubo;
    public Transform esfera;

    void Update()
    {
        Vector3 posicionObjetivo = esfera.position;

        // Hacer que el cubo mire hacia la esfera
        cubo.LookAt(posicionObjetivo);

        // Avanzar en la dirección que mira (eje Z positivo)
        // cubo.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);

    }
}
