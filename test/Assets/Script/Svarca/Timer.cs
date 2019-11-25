using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
	float timer=0.7f;
	bool istimer=false;
	void Update(){
		if (timer <= 0) {
			Destroy (gameObject);
		} else {
			if (istimer) {
				timer -= Time.deltaTime;
			} else {
				timer = 0.7f;
			}
		}

	}
	public void StartTimer(){
		istimer = true;
	}
	public void StopTimer(){
					istimer = false;
	}
}
