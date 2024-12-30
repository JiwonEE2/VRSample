using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
	public GameObject enemyPrefab;
	public float spawnRate = 3f;

	private void Update()
	{
		StartCoroutine(EnemySpawnCoroutine());
	}

	private IEnumerator EnemySpawnCoroutine()
	{
		yield return new WaitForSeconds(spawnRate);
		Vector3 pos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
		Instantiate(enemyPrefab, pos, Quaternion.identity);
	}
}