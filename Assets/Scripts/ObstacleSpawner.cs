using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

	[SerializeField] private float waitTime;
	[SerializeField] private GameObject[] obstaclePrefabs;
	private float tempTime;

	[Header("====TungDV====")]
	private int[] mPattern = { 0, 0, 0, 1, 1 };
	private int mIndexObstacle = 0;
	void Start(){
		tempTime = waitTime - Time.deltaTime;
		mIndexObstacle = 0;
	}

	void LateUpdate () {
		if(GameManager.Instance.GameState()){
			tempTime += Time.deltaTime;
			if(tempTime > waitTime){
				// Wait for some time, create an obstacle, then set wait time to 0 and start again
				tempTime = 0;
				// Clone Obstacles with pattern  by TungDV
				GameObject pipeClone = Instantiate(obstaclePrefabs[mPattern[mIndexObstacle]], transform.position, transform.rotation);
				mIndexObstacle++;
				if(mIndexObstacle >= (mPattern.Length))
                {
					mIndexObstacle = 0;
				}
				//GameObject pipeClone = Instantiate(obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)], transform.position, transform.rotation);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.transform.parent != null){
			Destroy(col.gameObject.transform.parent.gameObject);
		}else{
			Destroy(col.gameObject);
		}
	}

}
