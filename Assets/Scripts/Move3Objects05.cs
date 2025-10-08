using UnityEngine;

public class Move3Objects05 : MonoBehaviour
{
    public Transform objeto1;
    public Transform objeto2;
    public Transform objeto3;

    public Vector3 desplazamiento1;
    public Vector3 desplazamiento2;
    public Vector3 desplazamiento3;

    Vector3 posicionInicial1;
    Vector3 posicionInicial2;
    Vector3 posicionInicial3;

    void Start()
    {
        // Guardar las posiciones iniciales
        posicionInicial1 = objeto1.position;
        posicionInicial2 = objeto2.position;
        posicionInicial3 = objeto3.position;
    }

    void Update()
    {
        // Detectar si se presiona la barra espaciadora
        if (Input.GetAxis("Jump") > 0)
        {
            objeto1.position = posicionInicial1 + desplazamiento1;
            objeto2.position = posicionInicial2 + desplazamiento2;
            objeto3.position = posicionInicial3 + desplazamiento3;

            Debug.Log("Objetos desplazados a las nuevas posiciones.");
        }
    }
}
