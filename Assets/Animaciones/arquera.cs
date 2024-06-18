using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class arquera : MonoBehaviour
{

    private float inputX;
    private float inputZ;

    public float velocidad;
    public Animator anim;
   
    

 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputX=Input.GetAxis("Horizontal") *velocidad* Time.deltaTime;
        inputZ=Input.GetAxis("Vertical") *velocidad*Time.deltaTime;

        transform.Translate(inputX, 0, inputZ);
        Animaciones();
        
    }
    void Animaciones()
    {
        if(Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("salto");
        }

        //condicion para chequear que esta caminando
        if (inputZ != 0 || inputX != 0)
        {
            if  (Input.GetKey(KeyCode.C)) 
            {
                anim.SetInteger("estados", 3);
            }
            else
            {
                anim.SetInteger("estados", 1);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.C))
            {
                anim.SetInteger("estados", 1);
            }
            else
            {
                anim.SetInteger("estados", 0);
            }
        }
    }

}
