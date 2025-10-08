using UnityEngine;

public class ObjectsDistance04 : MonoBehaviour
{
    GameObject esfera;
    GameObject cubo;
    GameObject cilindro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Buscar los objetos por su etiqueta
        esfera = GameObject.FindWithTag("sphere");
        cubo = GameObject.FindWithTag("cube");
        cilindro = GameObject.FindWithTag("cylinder");

        // Verificar que se encontraron
        if (esfera == null || cubo == null || cilindro == null)
        {
            Debug.LogError("Faltan etiquetas: asegúrate de que la esfera, el cubo y el cilindro tengan sus tags asignadas.");
            return;
        }

        // Calcular distancias
        float distanciaCubo = Vector3.Distance(esfera.transform.position, cubo.transform.position);
        float distanciaCilindro = Vector3.Distance(esfera.transform.position, cilindro.transform.position);

        // Mostrar en consola
        Debug.Log("Distancia entre la esfera y el cubo: " + distanciaCubo);
        Debug.Log("Distancia entre la esfera y el cilindro: " + distanciaCilindro);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
