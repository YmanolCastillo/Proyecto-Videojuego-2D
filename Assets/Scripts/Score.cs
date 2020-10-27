using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue;
    public Text scoretx;

    private void Update()
    {
        scoretx.text = scoreValue.ToString();
    }

}
