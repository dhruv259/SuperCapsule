using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    float score = 0;
    float horizontal;
    float vertical;
    float speed = 9.0f;
    bool grounded = true;
    float jump = 7.5f;

    Rigidbody rb;
    public Canvas gameOverCanvas;
    public Canvas levelCompleteCanvas;
    public Text scoreDisplay;
    // GameObject child;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        // child = this.gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // float horizontal = Input.GetAxis("Horizontal");
        // float vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        this.transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);
        
        if(Input.GetButtonDown("Jump") && grounded)
        {
            rb.velocity = new Vector3(0, jump, 0);
            grounded = false;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "ground")
        {
            grounded = true;
        }
        if(other.gameObject.tag == "coin")
        {
            score++;
            scoreDisplay.text = "Score: " + score.ToString();
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "enemy")
        {
            this.gameObject.transform.DetachChildren();
            Destroy(this.gameObject);
            gameOverCanvas.gameObject.SetActive(true);
        }
        if(other.gameObject.tag == "enemy head")
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
        if(other.gameObject.tag == "victory")
        {
            Destroy(other.gameObject);
            this.gameObject.transform.DetachChildren();
            Destroy(this.gameObject);
            levelCompleteCanvas.gameObject.SetActive(true);
        }
    }
}
