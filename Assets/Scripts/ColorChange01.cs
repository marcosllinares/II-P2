using UnityEngine;

public class ColorChange01 : MonoBehaviour
{
    public int framesDeEspera = 120;

    private Color colorActual;
    private Renderer objetoRenderer;
    private int contadorFrames = 0;

    void Start()
    {
        // Inicializa el color con valores aleatorios entre 0 y 1
        colorActual = new Color(
            Random.value,
            Random.value,
            Random.value
        );

        // Obtiene el componente Renderer del objeto
        objetoRenderer = GetComponent<Renderer>();

        // Asigna el color inicial
        if (objetoRenderer != null)
            objetoRenderer.material.color = colorActual;
    }

    void Update()
    {
        contadorFrames++;

        if (contadorFrames >= framesDeEspera)
        {
            contadorFrames = 0;

            // Genera un color completamente nuevo con componentes r,g,b aleatorias
            colorActual = new Color(Random.value, Random.value, Random.value);

            // Aplica el nuevo color
            if (objetoRenderer != null)
                objetoRenderer.material.color = colorActual;
        }
    }
}
