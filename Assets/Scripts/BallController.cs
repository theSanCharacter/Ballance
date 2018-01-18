using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {
	private Rigidbody ball;
    public float speed;
    private int score;
    public Text scoreText;
	// Use this for initialization
	void Start () {
        score = 0;
		ball = GetComponent<Rigidbody> ();
        scoreText.text = "score:" + score;
	}
	
	// Update is called once per frame
	void Update () {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = - Input.GetAxis("Horizontal");
        Vector3 force = new Vector3(vertical, 0, horizontal);

        ball.AddForce(force*speed);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            score++;
            scoreText.text = "score:" + score;
        }
        if (other.CompareTag("WinZone"))
        {
            SceneManager.LoadScene("WinScene");
        }

    }
}
