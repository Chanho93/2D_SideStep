using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Create : MonoBehaviour
{
    public GameObject carsw;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Car_1", 1.0f);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Car_1()
    {
        carsw.SetActive(true);
    }
   
}
