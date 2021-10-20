using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator : MonoBehaviour
{
    public GameObject meteor;
    public Transform[] positions;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateMeteor());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GenerateMeteor()
    {
        int a = Random.Range(0, 4);
        Instantiate(meteor, positions[a].position, Quaternion.identity);
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(GenerateMeteor());
    }
}
