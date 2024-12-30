using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 1f;

	private void Update()
	{
		transform.Translate(speed * Time.deltaTime, 0, 0);
	}
}