using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Move : MonoBehaviour
{

    float vertical;
    public GameObject bALA;
    FixedJoystick Joy;

    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        Joy = FindObjectOfType<FixedJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Joy.Vertical;

        transform.position = transform.position + new Vector3(0, vertical,0 *1 * Time.deltaTime);

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Bala")
        {
            Destroy(this.gameObject);
            //Enciendo la Pantalla de Game Over
            GameOver.SetActive(true);
        }
        
    }


    public void shoot()
    {
        Instantiate(bALA, transform.position, Quaternion.identity);
    }
}
