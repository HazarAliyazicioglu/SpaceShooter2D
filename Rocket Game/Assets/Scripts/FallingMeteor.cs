using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingMeteor : MonoBehaviour
{
    public Vector2 speedMinMax;

    float speed;    

    // Update is called once per frame
    void Update()
    {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent());
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
