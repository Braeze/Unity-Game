using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nytscripthehe : MonoBehaviour
{
    public float floatfloat;
    public GameObject etellerandet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g")) {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown("h"))
        {
            GameObject nogetandet = Instantiate(etellerandet);
        }


        //transform.position += new Vector3(0, 0, floatfloat * Time.deltaTime);
        transform.Translate(transform.forward*Time.deltaTime*floatfloat);

        floatfloat += 0.01f;
    }
}
