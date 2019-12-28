using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public GameObject man;   
    public AudioSource PlayerAudio;

    // Start is called before the first frame update
    void Start()
    {
        PlayerAudio = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Car")
        {
            PlayerAudio.Play();
            if (SceneManager.GetActiveScene().name == "One_Step")
            {
               
                SceneManager.LoadScene(1);
                
            }
            else if(SceneManager.GetActiveScene().name == "Two_Step")
            {                
                SceneManager.LoadScene(2);
            }
            else if (SceneManager.GetActiveScene().name == "Three_Step")
            {                
                SceneManager.LoadScene(3);
            }

        }
    }







    public void LButton()
    {
       
        transform.Translate(-1.5f, 0f, 0f);
    }

    public void RButton()
    {
        transform.Translate(1.5f, 0f, 0f);
    }
}
