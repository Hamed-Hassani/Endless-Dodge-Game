using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{


    public float rotateSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, rotateSpeed));
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameManager.instance.GameOver();
        }

        else if (collision.gameObject.tag == "Ground")
        {
            GameManager.instance.IncerementScore();
            gameObject.SetActive(false);
            Destroy(gameObject, 3f);
        }
    }

}
