# 2D_SideStep

고속도로에서 차를 피하며 기록을 갱신해나가는 중독성게임

![image](https://user-images.githubusercontent.com/48191157/71569128-3f518680-2b10-11ea-868c-dc338c99a6db.png)
![image](https://user-images.githubusercontent.com/48191157/71569136-47112b00-2b10-11ea-9cd0-6256898e5301.png)
![image](https://user-images.githubusercontent.com/48191157/71569163-82abf500-2b10-11ea-8e40-303a8ab98474.png)

 ->오브젝트 풀링을 이용한 차 스폰
 
    public GameObject platformPrefab;
    public float speed;
    public int count = 5;
    public float timeBetSpawnMin = 1.0f;
    public float timeBetSpawnMax = 1.5f;
    private float timeBetSpawn;
    private GameObject[] platforms;
    private int currentIndex = 0;

    private Vector2 poolPosition = new Vector2(0, -20);
    private float lastSpawnTime;
    // Start is called before the first frame update
    void Start()
    {        
        platforms = new GameObject[count];
        for(int i= 0; i<count; i++)
        {
            platforms[i] = Instantiate(platformPrefab);
        }
        lastSpawnTime = 0f;
        timeBetSpawn = 0f;       
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.isGameover)
        {
            return;
        }
        if(Time.time >= lastSpawnTime + timeBetSpawn)
        {
            lastSpawnTime = Time.time;

            timeBetSpawn = Random.Range(timeBetSpawnMin, timeBetSpawnMax);            
          
            platforms[currentIndex].SetActive(false);
            platforms[currentIndex].SetActive(true);
            if (SceneManager.GetActiveScene().name == "One_Step")
            {
                platforms[currentIndex].transform.position = new Vector2(0.74f, 5.23f);
            }
            else if (SceneManager.GetActiveScene().name == "Two_Step")
            {
                platforms[currentIndex].transform.position = new Vector2(-0.73f, 5.23f);
            }
            else if (SceneManager.GetActiveScene().name == "Three_Step")
            {
                platforms[currentIndex].transform.position = new Vector2(-1.49f, 5.23f);
            }
            currentIndex++;
            if(currentIndex >= count)
            {
                currentIndex = 0;
            }
        }       
    }
    
 



PlayerPrefs을 이용한 최고점수 

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



     One Step      ->          Two Step     ->       Three Step         ->      Max Record

일정 시간이 넘으면 다음단계로 이동   -> 총 3단계  ->   마지막 단계에서는 기록 측정 -> 최고기록은 어플이 종료되어도 저장

