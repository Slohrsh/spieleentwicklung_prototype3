using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeIndicator : MonoBehaviour {

    private float actualDamageInScale;

    // Use this for initialization
    void Start () {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
    float deltaTime;
    // Update is called once per frame
    void Update () {
        
    }
    public void decreaseLife(float damage, float initialLife)
    {
        float scaledDamage = damage / initialLife;
        actualDamageInScale += scaledDamage;
        transform.localScale -= new Vector3(scaledDamage, 0, 0);
        changeColor();
    }

    public void Dead()
    {
        transform.gameObject.SetActive(false);
    }

    private void changeColor()
    {
        if (actualDamageInScale < 0.40)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        if (actualDamageInScale > 0.70)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (actualDamageInScale < 0.70 && actualDamageInScale > 0.40)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

    internal void increaseLife(int life, float initialLife)
    {
        float scaledDamage = life / initialLife;
        actualDamageInScale -= scaledDamage;
        transform.localScale += new Vector3(scaledDamage, 0, 0);
        changeColor();
    }
}
