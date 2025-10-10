using UnityEngine;

public class ShowPositions03 : MonoBehaviour
{
    Vector3 posicionActual;
    
    void Start()
    {
        posicionActual = GetComponent<Transform>().position;
        Debug.Log("Posición de la esfera: " + posicionActual);
    }
}
