using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputSystemKeyBoard : MonoBehaviour
{
    public float hor { get; private set; }
    public float ver { get; private set; }

    public event Action OnFire = delegate { }; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        if(Input.GetButtonDown("Fire1"))
        {
            OnFire();
        }
    }
}
