using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Create3 : MonoBehaviour
{
    public GameObject carsw1;
    public GameObject carsw2;
    public GameObject carsw3;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("Car_1", 1.0f);
        Invoke("Car_2", 2.0f);
        Invoke("Car_3", 3.0f);

    }

    // Update is called once per frame
    void Update()
    {

    }


    void Car_1()
    {
        carsw1.SetActive(true);
    }

    void Car_2()
    {
        carsw2.SetActive(true);
    }
    void Car_3()
    {
        carsw3.SetActive(true);
    }

}
