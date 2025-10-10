# Práctica 02 - Introducción C# - Scripts

Este proyecto corresponde a una práctica con Unity, cuyo objetivo es familiarizarse con el uso de scripts en C#.

## Autor

Trabajo realizado por Marcos Llinares Montes con alu0100972443

## Índice

- [Ejercicio 1](#ejercicio-1)
- [Ejercicio 2](#ejercicio-2)
- [Ejercicio 3](#ejercicio-3)
- [Ejercicio 4](#ejercicio-4)
- [Ejercicio 5](#ejercicio-5)
- [Ejercicio 6](#ejercicio-6)
- [Ejercicio 7](#ejercicio-7)
- [Ejercicio 8](#ejercicio-8)
- [Ejercicio 9 y 10](#ejercicio-9-y-10)
- [Ejercicio 11](#ejercicio-11)
- [Ejercicio 12](#ejercicio-12)
- [Ejercicio 13](#ejercicio-13)

### Ejercicio 1

![ChangeColor](https://i.imgur.com/sSs7uMt.gif)

```
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
```


### Ejercicio 2

![](https://i.imgur.com/ALilv4t.png)

![](https://i.imgur.com/aJicVfx.png)

```
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
```

### Ejercicio 3

![](https://i.imgur.com/z1GmXqr.png)

```
    Vector3 posicionActual;
    
    void Start()
    {
        posicionActual = GetComponent<Transform>().position;
        Debug.Log("Posición de la esfera: " + posicionActual);
    }
```
### Ejercicio 4

![](https://i.imgur.com/a1NDkI8.png)

![](https://i.imgur.com/O7TKRtV.png)

![](https://i.imgur.com/gajkJRk.png)
![](https://i.imgur.com/jRUPjw1.png)
![](https://i.imgur.com/QnG1186.png)

```
    GameObject esfera;
    GameObject cubo;
    GameObject cilindro;
    
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
        float distanciaCubo = Vector3.Distance(esfera.transform.position, cubo.transform.position);
        float distanciaCilindro = Vector3.Distance(esfera.transform.position, cilindro.transform.position);
        Debug.Log("Distancia entre la esfera y el cubo: " + distanciaCubo);
        Debug.Log("Distancia entre la esfera y el cilindro: " + distanciaCilindro);
    }
```

### Ejercicio 5

![Move3Objects](https://imgur.com/5ujyJQ5.gif)

![](https://i.imgur.com/iWxjAyu.png)

```
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
```

### Ejercicio 6

![](https://i.imgur.com/E29Xbs7.png)


```
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
```

### Ejercicio 7
![](https://i.imgur.com/XD6cMEF.png)

![](https://i.imgur.com/EZk4uJX.png)

```
    void Update()
    {
        // Detectar si se pulsa la tecla asignada al eje "Disparo"
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("¡Pium!¡Pium! - ¡Disparo activado!");
        }
    }
```
### Ejercicio 8

![DirectionalMovement](https://imgur.com/oKaOPZD.gif)

```
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 2f;                 // (> 1 por requisito inicial)
    public Space referenceSpace = Space.World;
    // Space.World o Space.Self

    void Update()
    {
        // Desplazamiento proporcional al vector, independiente de FPS
        transform.Translate(moveDirection * speed * Time.deltaTime, referenceSpace);

        // Versión sin dependencia de Time.deltaTime (no recomendable), depende del FPS
        // transform.Translate(moveDirection * speed, referenceSpace);
    }
```

![](https://i.imgur.com/g6fnTrP.png)

Comportamiento inicial:
El cubo se desplaza en el eje x y z hacia valores mayores (en diagona hacia atrás y de izq a dcha) a velocidad constante.

![](https://i.imgur.com/C84pYCB.png)


a. duplicas las coordenadas de la dirección del movimiento.

![](https://i.imgur.com/1W4J6sJ.png)

El vector MoveDirection en este caso es el doble. Se observa un comportamiento donde se mueve en la misma dirección que el original pero al doble de velocidad.

 Si bien apuntan a la misma dirección los dos vectores (`1, 0,1` y `2, 0, 2`) no tienen la misma magnitud y esto afecta a la fórmula con la que calculo el translate: 
`transform.Translate(moveDirection * speed * Time.deltaTime, referenceSpace);` 

b. duplicas la velocidad manteniendo la dirección del movimiento.

![](https://i.imgur.com/hAUNd9q.png)

Se observa un comportamiento donde la dirección es la misma (no la he cambiado) y la velocidad ha vuelto a duplicarse. De la misma forma que he explicado antes `speed` es un atributo que multiplica en la formúla del transform:
`transform.Translate(moveDirection * speed * Time.deltaTime, referenceSpace);` 


c. la velocidad que usas es menor que 1
A)
![](https://i.imgur.com/l2UylYr.png)

C)
![](https://i.imgur.com/vTqaS94.png)


- A) Con velocidad (1, 0) : El cubo se mueve en la misma dirección pero más lento.
- B) Con velocidad 0: El cubo no se mueve.
- C) Con velocidad negativa: El cubo va en dirección contraria a su vector dirección. (Como es lógico aplica el signo negativo a la multiplicación)

d. la posición del cubo tiene y>0

![](https://i.imgur.com/WQ3SAG0.png)

Lo único que ocurre es que la posición del cubo inicial es mayor que 0 por lo que se encuentra flotando y durante la ejecución se mantiene en esa altura como si estuviera "volando".

e. intercambiar movimiento relativo al sistema de referencia local y el mundial.

Si rotas el cubo, como ahora aplica a sus propios ejes locales la dirección del movimiento varía en función a la rotación que tenga el cubo moviendose en otra dirección diferente a la esperada pues ahora respecto a que se mueve son sus propios ejes.

### Ejercicio 9 y 10

![InputMove](https://imgur.com/8KsLQ2z.gif)

![](https://i.imgur.com/Zt7wA5E.png)


```
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
```

### Ejercicio 11

![FollowSphere](https://imgur.com/5IZ3C4k.gif)


```
    public Transform cubo;
    public Transform esfera;
    public float speed = 3f;

    void Update()
    {
        // Calcular dirección desde el cubo hacia la esfera
        Vector3 direccion = esfera.position - cubo.position;

        // Mantener la altura constante (y = 0)
        direccion.y = 0f;

        // Normalizar el vector para que su magnitud sea 1
        Vector3 direccionNormalizada = direccion.normalized;

        // Mover el cubo hacia la esfera a velocidad constante
        cubo.Translate(direccionNormalizada * speed * Time.deltaTime, Space.World);
    }
```
### Ejercicio 12

![](https://imgur.com/bPqguSd.gif)

```
    public Transform cubo;
    public Transform esfera;

    void Update()
    {
        Vector3 posicionObjetivo = esfera.position;

        // Hacer que el cubo mire hacia la esfera
        cubo.LookAt(posicionObjetivo);

        // Avanzar en la dirección que mira (eje Z positivo)
        // cubo.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);

    }
```

### Ejercicio 13

![](https://imgur.com/HllyXrX.gif)

```
    public float velocidadGiro = 500f;
    public float velocidadAvance = 2f;

    void Update()
    {
        // Leer el eje horizontal (teclas izquierda y derecha)
        float giro = Input.GetAxis("Horizontal");

        // Girar el objeto sobre su eje Y
        transform.Rotate(0f, giro * velocidadGiro * Time.deltaTime, 0f);

        // Avanzar en la dirección hacia adelante (eje Z positivo del objeto)
        transform.Translate(transform.forward * velocidadAvance * Time.deltaTime, Space.World);

        // Dibuja una línea (ray) en la dirección hacia adelante para depuración
        Debug.DrawRay(transform.position, transform.forward * 2f, Color.red);
    }
```
