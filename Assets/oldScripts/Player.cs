using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity;
    public int health;
    public GameObject explosion;
    public GameObject disparo;
    public float rotation;
    public int rotationVelocity = 10;

    private Rigidbody2D rb;
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = 0.0f;
        rotation = 0.0f;
        rotation = Input.GetAxisRaw("Horizontal");
        direction = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButtonDown(0))
        {
            Disparo();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(disparo, transform.position + new Vector3 (0.5f, 0.1f, 0.0f), Quaternion.identity);

            Instantiate(disparo, transform.position + new Vector3(-0.5f, -0.1f, -0.0f), Quaternion.identity);
        }
    }

    void Disparo()
    {
        Debug.Log("hola");
        Instantiate(disparo, transform.position, Quaternion.identity);
        Debug.Log("adios");
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.up * direction * velocity * Time.deltaTime);

        rb.transform.Rotate(0.0f, 0.0f, -rotation * rotationVelocity, Space.Self);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag.Equals("Meteor"))
        {
            health = health - 5;
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
