using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TANQUE : MonoBehaviour
{
    public float velocidadx = 3;
    public float rotacion = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, velocidadx * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -velocidadx * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotacion* Time.deltaTime,0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotacion *Time.deltaTime ,0) ;

        }

    }
}
