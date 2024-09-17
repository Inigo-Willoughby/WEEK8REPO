using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }

    public void pickUp(int increase){
      currentScore += increase;
    }
}
