using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rg;
    public float moveSpeed;
    public float rotateAmount;
    public float rot;
    int score;
    public GameObject winText;

    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos.x < 0)
            {
                rot = rotateAmount;
            }
            else
            {
                rot = -rotateAmount;
            }
            transform.Rotate(0,0,rot);
        }         
    }

    private void FixedUpdate()
    {
        rg.velocity = transform.up * moveSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
            score++;
            if (score >= 5)
            {
                print("Level Complete:");
                winText.SetActive(true);
            }
        }
        else if (collision.gameObject.tag == "Poison")
        {
            SceneManager.LoadScene("Game");
        }
    }

}
