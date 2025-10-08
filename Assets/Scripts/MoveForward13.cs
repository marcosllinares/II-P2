using UnityEngine;

public class MoveForward13 : MonoBehaviour
{
    public float velocidadGiro = 500f;
    public float velocidadAvance = 2f;

    void Update()
    {
        // Leer el eje horizontal (teclas izquierda y derecha)
        float giro = Input.GetAxis("Horizontal");

        // Girar el objeto sobre su eje Y
        transform.Rotate(0f, giro * velocidadGiro * Time.deltaTime, 0f);

        // Avanzar en la dirección hacia adelante (eje Z positivo del objeto)
        transform.Translate(transform.forward * velocidadAvance * Time.deltaTime, Space.World);

        // Dibuja una línea (ray) en la dirección hacia adelante para depuración
        Debug.DrawRay(transform.position, transform.forward * 2f, Color.red);
    }
}
