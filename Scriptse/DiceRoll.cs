using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class DiceRoll : MonoBehaviour
{
    public Animator anim;
    private float number;

    private bool ScoreRoll = false;
    public float ScorNumber;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (number == 1)
        {
            anim.SetTrigger("One");
            number = 0;
        }

        if (number == 2)
        {
            anim.SetTrigger("Two");
            number = 0;
        }

        if (number == 3)
        {
            anim.SetTrigger("Three");
            number = 0;
        }

        if (number == 4)
        {
            anim.SetTrigger("Four");
            number = 0;
        }

        if (number == 5)
        {
            anim.SetTrigger("Five");
            number = 0;
        }

        if (number == 6)
        {
            anim.SetTrigger("Six");
            number = 0;
        }
    }

    public void Thought()
    {
        if (ScorNumber > 0 || ScorNumber == 1)
        {
            ScoreRoll = true;
            ScorNumber--;
            if (ScorNumber < 0 || ScorNumber == 0)
            {
                ScoreRoll = false;
            }
        }
        

        if (ScoreRoll == true)
        {
            Roll();

            ScoreRoll = false;
        }
    }

    public void Roll()
    {

        anim.SetTrigger("Roll");

        number = Random.Range(1, 6);

        Debug.Log(number);
    }
}