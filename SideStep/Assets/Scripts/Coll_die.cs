using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Coll_die : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "One_Step")
            {
                SceneManager.LoadScene(1);
            }
            else if (SceneManager.GetActiveScene().name == "Two_Step")
            {
                SceneManager.LoadScene(2);
            }
            else if (SceneManager.GetActiveScene().name == "Three_Step")
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
