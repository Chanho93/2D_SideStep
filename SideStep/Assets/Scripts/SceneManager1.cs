using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneManager1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text TimeText;

    public float count = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;

       // TimeText.text = count + "초";
        TimeText.text = string.Format("{0:N2}초", count);



        if (count >= 5)
        {
            SceneManager.LoadScene(2);
        }
    }
}

