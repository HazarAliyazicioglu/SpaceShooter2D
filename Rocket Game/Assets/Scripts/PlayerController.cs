using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject menu;
    public float speed = 7;
    
    float screenWidthLimit;
    

    void Start()
    {
        float halfplayerWidth = transform.localScale.x / 2f;
        screenWidthLimit = Camera.main.aspect * Camera.main.orthographicSize - halfplayerWidth;
    }

    
    void Update()
    { 
        
        Vector2 inputX = new Vector2 (Input.GetAxisRaw("Horizontal"),0);
        transform.Translate(inputX * speed * Time.deltaTime);
        if (transform.position.x < -screenWidthLimit)
        {
            transform.position = new Vector2(-screenWidthLimit,transform.position.y);
        }
        if (transform.position.x > screenWidthLimit)
        {
            transform.position = new Vector2(screenWidthLimit,transform.position.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Meteor")
        {
            Destroy(gameObject);
            menu.SetActive(true);
        }
    }

}
