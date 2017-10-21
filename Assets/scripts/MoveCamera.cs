using UnityEngine;
using System.Collections;


public class MoveCamera : MonoBehaviour {

			public Rigidbody2D rb;

			void OnTriggerEnter2D(Collider2D other)
			{
					if (other.gameObject.CompareTag("Collect"))
					{
							Destroy(other.gameObject);
					}

					if (other.gameObject.CompareTag("Enemy"))
					{
							Destroy(other.gameObject);
					}
			}

}
