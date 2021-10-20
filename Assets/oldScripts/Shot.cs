using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        var videojugador = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        rb = GetComponent<Rigidbody2D>();

        rb.rotation = videojugador.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(transform.position + transform.up * velocity * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Meteor"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
