﻿using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	
	// Use this for initialization
	float spawnTimer;
	float timeNeeded;
	public GameObject[] blocs;
	
	private int rand;
	
	void Awake()
	{
		spawnTimer = 0;
		timeNeeded = 0;
	}
	
	void Update () 
	{
		spawnTimer += Time.deltaTime;
		
		if (spawnTimer > timeNeeded) 
		{
			SpawnBloc();
			spawnTimer = 0;
			timeNeeded = Random.Range(0.3f, 2.5f);
		}
	}
	
	void SpawnBloc()
	{
		Vector3 pos = new Vector3(transform.position.x, Random.Range(-10, -6), 0);
		Instantiate(blocs[Random.Range(0, blocs.Length)], pos, Quaternion.identity);
	}
}