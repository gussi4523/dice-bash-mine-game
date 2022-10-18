using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

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
        if(number == 1)
        {
            anim.SetTrigger("One");
        }

        if (number == 2)
        {
            anim.SetTrigger("Two");
        }

        if (number == 3)
        {
            anim.SetTrigger("Tree");
        }

        if (number == 4)
        {
            anim.SetTrigger("Four");
        }

        if (number == 5)
        {
            anim.SetTrigger("Five");
        }

        if (number == 6)
        {
            anim.SetTrigger("Six");
        }
    }

    public void Thought()
    {
        if (ScorNumber > 0)
        {
            ScorNumber--;
            ScoreRoll = true;
        }

        if (ScorNumber < 0)
        {
            ScoreRoll = false;
        }

        if (ScorNumber == 0)
        {
            ScoreRoll = false;
        }

        if(ScoreRoll == true)
        {
            Roll();
        }
    }

    public void Roll()
    {
      
            anim.SetTrigger("Roll");

            number = Random.Range(1, 6);

            Debug.Log(number);
    }
}
