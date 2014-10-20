using UnityEngine;
using System.Collections;

public class CrateMovement : MonoBehaviour
{

		public bool range = false ;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{

				if (transform.position.x > -35) {
						range = true;
				} else if (transform.position.x < -45)  {
						range = false;
				}


		if (range == true) {
			transform.Translate (Vector3.right * -0.1f, Space.World);
		}
		else
		{
			transform.Translate (Vector3.right * 0.1f, Space.World);
		}

		}
}

