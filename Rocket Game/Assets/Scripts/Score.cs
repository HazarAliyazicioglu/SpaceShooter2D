using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Net;

public class Score : MonoBehaviour
{
    public static float score = 0;
    public  TextMeshProUGUI myScoreText;
    

    public void Start()
    {
       BulletCollider.PlayerGetsScore += AddScore;
        
    }
    public void AddScore ()
    {
        score += 1;
        myScoreText.text = "Score: " + score.ToString();
    }

}
