using UnityEngine;

public class ShowPositions03 : MonoBehaviour
{
    Vector3 posicionActual;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionActual = GetComponent<Transform>().position;

        // Muestra en pantalla (Consola)
        Debug.Log("Posición de la esfera: " + posicionActual);
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
