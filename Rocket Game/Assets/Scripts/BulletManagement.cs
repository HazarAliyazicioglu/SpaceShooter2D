using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManagement : MonoBehaviour
{
    public Vector2 playerLocation;
    public GameObject bullet;

    PlayerController player;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerLocation = new Vector2(player.transform.position.x, player.transform.position.y);
            GameObject bulletClones = Instantiate(bullet, new Vector2(playerLocation.x, playerLocation.y + 0.8f), Quaternion.identity);
            bulletClones.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 15f,ForceMode2D.Impulse);

        }
    }
}
