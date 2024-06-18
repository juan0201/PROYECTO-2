using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidadz = 0;
    public float velocidady = 2;
    public float velocidadx = 5;
    public float rotacionz = 4;
    public float rotacionx = 3;
    public float rotaciony = 8;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, velocidadz * Time.deltaTime);
        transform.Rotate(0, rotaciony * Time.deltaTime, 0);
    }
}
