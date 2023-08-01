using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PrefabSpawn : MonoBehaviour
{
    public GameObject meteor;
    public Vector2 secondsBetweenSpawnsMinMax;
    public float speed = 7;
    public float spawnAngleMax;

    float screenWidthLimit;
    float nextSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        float halfplayerWidth = transform.localScale.x / 2f;
        screenWidthLimit = Camera.main.aspect * Camera.main.orthographicSize - halfplayerWidth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            float secondsBetweenSpawns = Mathf.Lerp(secondsBetweenSpawnsMinMax.y, secondsBetweenSpawnsMinMax.x, Difficulty.GetDifficultyPercent());
            float spawnAngle = Random.Range(-spawnAngleMax, spawnAngleMax);
            nextSpawnTime = Time.time + secondsBetweenSpawns;
            GameObject meteorClones = (GameObject)Instantiate(meteor, new Vector2((Random.Range(screenWidthLimit, -screenWidthLimit)), 6.1f), Quaternion.Euler(Vector3.forward * spawnAngle));
            meteorClones.transform.localScale = Vector2.one * Random.Range(0.5f, 2f);
        }
    }

    

}
