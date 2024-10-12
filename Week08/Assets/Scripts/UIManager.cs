using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static private UIManager instance;
    static public UIManager Instance
    {
        get 
        {
            return instance;
        }
    }
    [SerializeField] private TextMeshProUGUI scoreText; 
    [SerializeField] private string scoreFormat = "Score: {0}";
    void Awake()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance=this;
        }
    }
    void Update()
    {
        scoreText.text = string.Format(scoreFormat, ScoreKeeper.Score);
    }
}
