using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bala : MonoBehaviour
{
    [Header("Pantallas para Encender")]
    public GameObject Nivel2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * 60 * Time.deltaTime;
 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Score.scoreValue += 20;
            Destroy(collision.gameObject);
           

        }
        if (Score.scoreValue > 500)
        {
            //Nivel2.SetActive(true);
            SceneManager.LoadScene("GameLevel2");
        }

}
    public void GoToLevel()
    {
        SceneManager.LoadScene("GameLevel2");
    }

  
}
