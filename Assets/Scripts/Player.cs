using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private UIManager UIManager;
    private Animator _anim;

    private void Start()
    {
        UIManager = FindObjectOfType(typeof(UIManager)) as UIManager;
        _anim = GetComponent<Animator>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            AnimationControl("Hit");
            UIManager.TakeDamage();
            
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        _anim.SetBool("Hit", false);
    }

    public void Die()
    {
        AnimationControl("Die");
    }

    private void AnimationControl(string state)
    {
        switch (state)
        {
            case "Hit":
                _anim.SetBool("Hit", true);
                break;
            case "Die":
                _anim.SetBool("Die", true);
                this.GetComponent<PlayerMovement>().enabled = false;
                break;
        }
    }


}
