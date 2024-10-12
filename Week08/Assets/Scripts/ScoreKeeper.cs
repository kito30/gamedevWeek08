using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private static float score=0;
    public static float Score
    {
        get
        {
            return score;
        }
    }
    public void OnPickup(float scoreRate)
    {
        score += scoreRate;
    }
}
