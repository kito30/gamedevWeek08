using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private static float score=0;
    private static float score2 = 0;   
    private static ScoreKeeper instance;
    [SerializeField] private string p1Tag;
    [SerializeField] private string p2Tag;
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
    public static float Score2
    {
        get
        {
            return score2;
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
    public void OnPickup(float scoreRate, GameObject gameObject)
    {
        if(gameObject.tag == p1Tag)
        {
            score += scoreRate;
        }
        else if (gameObject.tag == p2Tag)
        {
            score2 += scoreRate;
        }
    }

    
}
