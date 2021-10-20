using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSystem : MonoBehaviour
{
    [SerializeField]
    private Transform shotPoint;

    [SerializeField]
    private GameObject projectile;

    [SerializeField]
    private int fireForce;

    private void OnEnable()
    {
        GetComponent<InputSystemKeyBoard>().OnFire += Shoot;
    }

    private void OnDisable()
    {
        GetComponent<InputSystemKeyBoard>().OnFire -= Shoot;
    }

    private void Shoot()
    {
        var shot = Instantiate(projectile, shotPoint.position, shotPoint.rotation);
        shot.GetComponent<Rigidbody2D>().AddForce(shotPoint.transform.up * fireForce);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
