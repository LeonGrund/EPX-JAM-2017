using UnityEngine;
using System.Collections;


public class EnemySpawn : MonoBehaviour {

	public GameObject sEnemy;
	public GameObject bEnemy;
	private Vector2 position;

	void Start () {
		// set random start
		float x = Random.Range(0,20);
		float y = 3f;		//standard
		position = new Vector2(x,y);

		Wave1();
		Wave2();

	}

	void Wave1 () {
		int amt = Random.Range(10,20);

		for (int i = 0; i <= amt; i++) { //spwan enemies equalt to amt
			//advance enemy spawning postion by (x,y)
			float new_x = Random.Range(0,20);
			float new_y = Random.Range(5,10);
			float old_y = position.y;

			position = new Vector2(new_x, (new_y + old_y));

			Instantiate(bEnemy, position, Quaternion.identity);
		}

	}

	void Wave2 () {
		int amt = Random.Range(20,30);

		for (int i = 0; i <= amt; i++) { //spwan enemies equalt to amt
			//advance enemy spawning postion by (x,y)
			float new_x = Random.Range(0,20);
			float new_y = Random.Range(3,7);
			float old_y = position.y;

			position = new Vector2(new_x, (new_y + old_y));

			Instantiate(sEnemy, position, Quaternion.identity);
		}

	}

}
