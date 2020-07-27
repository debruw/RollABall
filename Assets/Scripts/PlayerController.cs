using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5;
    int count = 0;
    public int x;
    public Text ScoreText, WinText;
    int TargetCount = 3;
    public FixedJoystick joystick;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        rb.AddForce(movement * speed);       

        //Touch touch = Input.GetTouch(0);
        //touch.phase;
        //TouchPhase.
        //Input.touchCount
        //Input.touches
        //touch.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        //other.gameObject.tag == "Collectible"
        if (other.gameObject.CompareTag("Collectible"))
        {
            //objeyi topla
            //collision.gameObject.SetActive(false);
            Destroy(other.gameObject);
            //count = count + 1;
            //count += 1;
            count++;
            ScoreText.text = "Score : " + count.ToString();
            if (count >= TargetCount)
            {
                // Oyunu kazandık
                WinText.gameObject.SetActive(true);
            }
        }
    }

}
