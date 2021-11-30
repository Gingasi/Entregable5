using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    
    private float speed = 10f;
    public Vector3 initialPos;
    private float verticalInput;
    private float turnspeed = 20f;
    private float zMax = 450f;

    void Start()
    {
        transform.position = initialPos; //indicamos la posición inicial
    }

    void Update()
    {
        //Hacemos que el personaje se mueva en x y a una velocidad constante. Así como la rotación arriba y abajo
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
            verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * turnspeed * Time.deltaTime * -verticalInput);
       //Indicamos que si pasa una cantidad salga un mensaje de the end
        if (transform.position.z >= zMax)
        {
            Debug.Log("GAME OVER, THE END");
            Time.timeScale = 0;
        }
    }
}
