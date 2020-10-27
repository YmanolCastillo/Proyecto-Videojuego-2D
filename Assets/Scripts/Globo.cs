using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo : MonoBehaviour
{
    public Sprite [] globosprite;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer ElSprite = GetComponent<SpriteRenderer>();
        ElSprite.sprite = globosprite[Random.Range(0, globosprite.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0.1f, 0 * Time.deltaTime);   
    }

    
}
