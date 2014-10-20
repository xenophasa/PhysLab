using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
		public GameObject gun;
	public int healthPacks = 0;




		//Controls collisions and pick-ups
		void OnControllerColliderHit (ControllerColliderHit hit)
		{
				if (hit.gameObject.name == "machineGun") {
						Debug.Log ("Object picked up " + hit.gameObject.name);
						Destroy (hit.gameObject);
						gun.SetActive (true);
				}

		if (hit.gameObject.name == "healthpack") {
						Debug.Log ("Object picked up " + hit.gameObject.name);
						Destroy (hit.gameObject);
			healthPacks ++ ; 
			Debug.Log(healthPacks);
				}

		}


	void OnGUI ()
	{
		GUI.Label (new Rect (110, 50, 80, 40), healthPacks.ToString());
		}

		// Update is called once per frame
		void Update ()
		{
				if (gun.active) {
						if (Input.GetButtonDown ("Fire1")) {
								Ray ray =
					Camera.main.ScreenPointToRay (Input.mousePosition);
								RaycastHit hit = new RaycastHit ();
								if (Physics.Raycast (ray, out hit)) {
										if (hit.collider.gameObject.name == "barrel") {
						Debug.Log ("Hit the barrel");
						Destroy(hit.collider.gameObject);
										}
					if (hit.collider.gameObject.name == "barrel2"){
						Debug.Log("Hit the metal barrel");
						Destroy(hit.collider.gameObject);
					}
								}
						}
				}
		}
}
