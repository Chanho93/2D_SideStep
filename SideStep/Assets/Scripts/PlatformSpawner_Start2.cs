using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlatformSpawner_Start2 : MonoBehaviour
{
    public GameObject platformPrefab;


    public float speed;
    public int count = 1;

    public float timeBetSpawnMin = 1.0f;
    public float timeBetSpawnMax = 1.5f;
    private float timeBetSpawn;

    //   public float yMin = 0f;
    // public float yMax = 4f;

    private GameObject[] platforms;
    private int currentIndex = 0;

    private Vector2 poolPosition = new Vector2(0, -20);
    private float lastSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        platforms = new GameObject[count];

        for (int i = 0; i < count; i++)
        {
            platforms[i] = Instantiate(platformPrefab);
        }
        lastSpawnTime = 0f;
        timeBetSpawn = 0f;

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= lastSpawnTime + timeBetSpawn)
        {
            lastSpawnTime = Time.time;

            timeBetSpawn = Random.Range(timeBetSpawnMin, timeBetSpawnMax);




            // float yPos = Random.Range(yMin, yMax);

            platforms[currentIndex].SetActive(false);
            platforms[currentIndex].SetActive(true);

            if (SceneManager.GetActiveScene().name == "Start")
            {
                platforms[currentIndex].transform.position = new Vector2(-0.77f, 5.23f);

            }

            currentIndex++;
            if (currentIndex >= count)
            {
                currentIndex = 0;
            }
        }

    }
}

