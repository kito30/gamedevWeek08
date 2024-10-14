using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] private float point;
    void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
        ScoreKeeper.ScoreKeeperInstance.OnPickup(point,collider.gameObject); 
    }
}
