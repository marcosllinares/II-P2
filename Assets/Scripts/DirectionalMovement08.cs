using UnityEngine;

public class DirectionalMovement08 : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 2f;                 // (> 1 por requisito inicial)
    public Space referenceSpace = Space.World;
    // Space.World o Space.Self

    void Start()
    {
        // Requisito: posición inicial con y = 0
        // Vector3 p = transform.position;
        // transform.position = new Vector3(p.x, 0f, p.z);
        
    }

    void Update()
    {
        // Desplazamiento proporcional al vector, independiente de FPS
        transform.Translate(moveDirection * speed * Time.deltaTime, referenceSpace);

        // Versión sin dependencia de Time.deltaTime (no recomendable), depende del FPS
        // transform.Translate(moveDirection * speed, referenceSpace);
    }

}
