using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    HeartsSrc HeartSrc;
    Player Player;
    private int _countHits = 0;


    private void Start()
    {
        HeartSrc = FindObjectOfType(typeof(HeartsSrc)) as HeartsSrc;
        Player = FindObjectOfType(typeof(Player)) as Player;
    }
    public void TakeDamage()
    {
        HeartSrc.Hit(_countHits);
        _countHits++;
        if (_countHits == HeartSrc.HealthCount)
            Player.Die();
    }

    
}
