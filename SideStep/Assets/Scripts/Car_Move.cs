using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Car_Move : MonoBehaviour
{
    public float speed;
    public float count;

   

    // Start is called before the first frame update
    void Start()
    {

        speed = Random.Range(0.15f, 0.22f);

    }
    // Update is called once per frame
    void Update()
    {
     

        transform.Translate(speed, 0f, 0f);

    }

  
}
