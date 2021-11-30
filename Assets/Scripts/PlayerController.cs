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
        transform.position = initialPos;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
            verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * turnspeed * Time.deltaTime * -verticalInput);
       
        if (transform.position.z >= zMax)
        {
            Debug.Log("GAME OVER, THE END");
            Time.timeScale = 0;
        }
    }
}
