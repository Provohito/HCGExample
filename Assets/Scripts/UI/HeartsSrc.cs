using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsSrc : MonoBehaviour
{
    public int HealthCount 
    {
        get { return _healthCount; }
        private set { ;} 
    }
    [SerializeField] GameObject _healthPrefab;

    [SerializeField] private int _healthCount;


    private void Start()
    {
        InitHearts();
    }

    private void InitHearts()
    {
        for (int i = 0; i < _healthCount; i++)
        {
            GameObject heartTemplate = Instantiate(_healthPrefab);
            heartTemplate.transform.SetParent(this.transform);
        }
        
       
    }

    public void Hit(int number)
    {
        HitPlayer(number);
    }

    private void HitPlayer(int number)
    {
        this.transform.GetChild(number).gameObject.GetComponent<Image>().color = Color.white;
    }
}
