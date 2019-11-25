using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSvarca : MonoBehaviour {
	SettingsSvarca ss;
	GameObject gg;
	float timer=0f;
	void Start(){
		ss = FindObjectOfType<SettingsSvarca>();
	}
	void Update()
	{
		if (Buttons.GetIsActiveSvarca ()) {
			if (Input.GetMouseButton (0)) {
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (ray, out hit)) {
					StartCoroutine (CreateSeam (hit));
				} else
					StopAllCoroutines ();
			}else 
				StopAllCoroutines ();
		}
	}
	IEnumerator CreateSeam(RaycastHit hit){
		yield return new WaitForSeconds (0.1f);
		if (gg != null) {
			if (hit.collider.tag == "Vanna") {
				gg.GetComponent<Timer> ().StopTimer ();

			} else {
				gg.GetComponent<Timer> ().StartTimer ();
				gg = Instantiate (ss.GetVannaSeam (), hit.point, Quaternion.identity);
			}

		} else {
			gg = Instantiate (ss.GetVannaSeam (), hit.point, Quaternion.identity);

		}		
		gg.transform.parent = hit.transform;

	}
}
