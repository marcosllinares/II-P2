using UnityEngine;

public class VectorMagnitudes02 : MonoBehaviour
{
    public Vector3 vectorA;
    public Vector3 vectorB;

    private float magnitudA;
    private float magnitudB;
    private float angulo;
    private float distancia;
    private string vectorMasAlto;

    void Start()
    {
        // Cálculos
        magnitudA = vectorA.magnitude;
        magnitudB = vectorB.magnitude;
        angulo = Vector3.Angle(vectorA, vectorB);
        distancia = Vector3.Distance(vectorA, vectorB);

        // Comparación de altura (eje Y)
        if (vectorA.y > vectorB.y)
            vectorMasAlto = "Vector A está más alto.";
        else if (vectorA.y < vectorB.y)
            vectorMasAlto = "Vector B está más alto.";
        else
            vectorMasAlto = "Ambos están a la misma altura.";

        // Mostrar en consola
        Debug.Log($"Magnitud de A: {magnitudA:F2}");
        Debug.Log($"Magnitud de B: {magnitudB:F2}");
        Debug.Log($"Ángulo entre A y B: {angulo:F2} grados");
        Debug.Log($"Distancia entre A y B: {distancia:F2}");
        Debug.Log(vectorMasAlto);
    }
}
