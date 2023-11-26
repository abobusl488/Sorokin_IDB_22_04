using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class Test : MonoBehaviour
{

    public GameObject sphere;

    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            sphere = GameObject.Find("Sphere");
            inst();
        }
    }

    void inst()
    {
        for(int i = 0; i < 10; ++i)
        {
            Vector3 nv = new Vector3(i, 0, 0);
            Instantiate(sphere, nv, sphere.transform.rotation);
        }
    }
}
