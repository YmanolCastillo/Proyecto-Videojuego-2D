using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intanciador : MonoBehaviour
{
    public GameObject ElGlobo;
    float Timer = 0;
    float maxTime = 2;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > maxTime)
        {
            Instantiate(ElGlobo, new Vector3(Random.Range(-80, 80), -40, 0), Quaternion.identity);
            Timer = 0;

        }
        Timer +=Time.deltaTime;
    }
}