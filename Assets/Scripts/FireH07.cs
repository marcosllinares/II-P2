using UnityEngine;

public class FireH07 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Detectar si se pulsa la tecla asignada al eje "Disparo"
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("¡Pium!¡Pium! - ¡Disparo activado!");
        }
    }
}
