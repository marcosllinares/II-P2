using UnityEngine;

public class VelocityCube06 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float velocidad = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Flecha arriba
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float resultado = velocidad * vertical;
            Debug.Log("Flecha Arriba → Resultado: " + resultado);
        }

        // Flecha abajo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            float resultado = velocidad * vertical;
            Debug.Log("Flecha Abajo → Resultado: " + resultado);
        }

        // Flecha derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            float resultado = velocidad * horizontal;
            Debug.Log("Flecha Derecha → Resultado: " + resultado);
        }

        // Flecha izquierda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float resultado = velocidad * horizontal;
            Debug.Log("Flecha Izquierda → Resultado: " + resultado);
        }
    }
}
