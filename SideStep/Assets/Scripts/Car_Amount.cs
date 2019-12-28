using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Amount : MonoBehaviour
{
    public GameObject[] cars;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnEnable()
    {
      

        for(int i = 0; i< cars.Length; i++)
        {
            if(Random.Range(0,5) == 0)
            {
                cars[i].SetActive(true);
            }
            else
            {
                cars[i].SetActive(false);
            }
        }
    }
    

  
}
