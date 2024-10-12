using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private static float score=0;
    private static ScoreKeeper instance;
    public static ScoreKeeper ScoreKeeperInstance
    {
        get
        {
            return instance;
        }
    }
    public static float Score
    {
        get
        {
            return score;
        }
    }
    void Awake()
    {
         if (instance != null)
         {
             Destroy(gameObject);
         }
         else
         {
            instance = this;
         }
    }
    public void OnPickup(float scoreRate)
    {
        score += scoreRate;
    }
}
