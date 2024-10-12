using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private static float score=0;
    [SerializeField] private float scoreRate;
    public static float Score
    {
        get
        {
            return score;
        }
    }
    public void OnPickup()
    {
        score += scoreRate;
    }
}
