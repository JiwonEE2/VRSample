using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
	public float speed = 10f;
	public float lifetime = 10f;
	private Rigidbody rb;
	public Text scoreText;
	private int score = 0;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Start()
	{
		Destroy(gameObject, lifetime);
	}

	private void Update()
	{
		Vector3 force = transform.forward * speed;
		rb.AddForce(force);
		scoreText.text = "Score: " + score.ToString();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy"))
		{
			score++;
			Destroy(other.gameObject);
		}
	}
}