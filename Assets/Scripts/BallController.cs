using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	private Rigidbody ball;
    public float speed;
	// Use this for initialization
	void Start () {
		ball = GetComponent<Rigidbody> ();
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
        }
        
    }
}
