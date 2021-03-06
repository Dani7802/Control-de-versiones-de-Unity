using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float turnSpeed;

    private InputSystemKeyBoard inputSystem;

    void Awake()
    {
        inputSystem = GetComponent<InputSystemKeyBoard>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += inputSystem.ver * transform.up * speed * Time.deltaTime;
        transform.Rotate(new Vector3(0, 0, -1) * inputSystem.hor * turnSpeed * Time.deltaTime);
    }
}
