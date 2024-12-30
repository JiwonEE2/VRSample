using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 10f;
	public float lifetime = 10f;
	private Rigidbody rb;

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
	}
}