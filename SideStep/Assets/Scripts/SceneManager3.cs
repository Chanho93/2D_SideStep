using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneManager3 : MonoBehaviour
{

    static SceneManager3 _instance = null;

    public static SceneManager3 Instance()
    {
        return _instance;
    }
    // Start is called before the first frame update
    public Text TimeText;
    public Text MaxText;

    public float count = 0;
    public float Max = 0;

    public float bestScore
    {
        get{return Max;}
    }

    public float myScore
    {
        get { return count; }

        set { 

         if(Max<count)
        {
            Max = count;
            saveScore();
}

          //  MaxText.text = string.Format("최고기록    {0:N2}초", Max);
        }
    }
    void Start()
    {
        if (_instance == null) //싱글톤 인스턴스가 없다면?  그저 싱글톤패턴 지금은 굳이 알 필요 없음
            _instance = this; //현재 인스턴스로 결정
        else
            Destroy(gameObject); //이미 싱글톤 인스턴스가 있다면 현재 오브젝트 파괴

        LoadBestScore(); //최고점 불러오기.

        MaxText.text = string.Format("최고기록    {0:N2}초", Max);
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;

       TimeText.text = string.Format("{0:N2}초", count);

        if(Max < count)
        {
            saveScore();
        }
            
    }

    public void saveScore()
    {
        Max = count;
        PlayerPrefs.SetFloat("최고기록", Max);
        MaxText.text = string.Format("최고기록    {0:N2}초", Max);
    }

    void LoadBestScore()
    {
        Max = PlayerPrefs.GetFloat("최고기록", 0);//최고점수 불러오기 초기값
    }
}


