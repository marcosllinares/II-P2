using UnityEngine;

public class FollowSphere11 : MonoBehaviour
{
    public Transform cubo;
    public Transform esfera;
    public float speed = 3f;

    void Update()
    {
        // Calcular dirección desde el cubo hacia la esfera
        Vector3 direccion = esfera.position - cubo.position;

        // Mantener la altura constante (y = 0)
        direccion.y = 0f;

        // Normalizar el vector para que su magnitud sea 1
        Vector3 direccionNormalizada = direccion.normalized;

        // Mover el cubo hacia la esfera a velocidad constante
        cubo.Translate(direccionNormalizada * speed * Time.deltaTime, Space.World);
    }
}
