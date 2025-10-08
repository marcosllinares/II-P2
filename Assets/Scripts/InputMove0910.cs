using UnityEngine;

public class InputMove0910 : MonoBehaviour
{
    public Transform cubo;
    public Transform esfera;
    public float speedCubo = 5f;
    public float speedEsfera = 5f;

    void Update()
    {
        // Movimiento del cubo con flechas
        float moverCuboVertical = 0f;
        float moverCuboHorizontal = 0f;

        if (Input.GetKey(KeyCode.UpArrow)) moverCuboVertical = 1f;
        if (Input.GetKey(KeyCode.DownArrow)) moverCuboVertical = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) moverCuboHorizontal = 1f;
        if (Input.GetKey(KeyCode.LeftArrow)) moverCuboHorizontal = -1f;


        Vector3 movimientoCubo = new Vector3(moverCuboHorizontal, 0f, moverCuboVertical);
        // Ejercicio 10: Con DeltaTime
        cubo.Translate(movimientoCubo * speedCubo * Time.deltaTime, Space.World);

        // Ejercicio 9: Sin DeltaTime
        // cubo.Translate(movimientoCubo * speedCubo, Space.World);

        // Movimiento de la esfera con WASD
        float moverEsferaVertical = 0f;
        float moverEsferaHorizontal = 0f;

        if (Input.GetKey(KeyCode.W)) moverEsferaVertical = 1f;
        if (Input.GetKey(KeyCode.S)) moverEsferaVertical = -1f;
        if (Input.GetKey(KeyCode.D)) moverEsferaHorizontal = 1f;
        if (Input.GetKey(KeyCode.A)) moverEsferaHorizontal = -1f;

        Vector3 movimientoEsfera = new Vector3(moverEsferaHorizontal, 0f, moverEsferaVertical);
        // Ejercicio 10: Con DeltaTime
        esfera.Translate(movimientoEsfera * speedEsfera * Time.deltaTime, Space.World);

        // Ejercicio 9: Sin DeltaTime
        // esfera.Translate(movimientoEsfera * speedEsfera, Space.World);
    }
}
