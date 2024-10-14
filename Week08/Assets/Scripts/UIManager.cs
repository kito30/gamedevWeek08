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
    [SerializeField] private TextMeshProUGUI p1ScoreText; 
    [SerializeField] private TextMeshProUGUI p2ScoreText; 
    [SerializeField] private string p1ScoreFormat = "P1 Score: {0}";
    [SerializeField] private string p2ScoreFormat = "P2 Score: {0}";
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
        p1ScoreText.text = string.Format(p1ScoreFormat, ScoreKeeper.Score);
        p2ScoreText.text = string.Format(p2ScoreFormat, ScoreKeeper.Score2);
    }
}
