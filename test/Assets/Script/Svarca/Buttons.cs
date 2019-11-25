using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {
	static bool IsActiveSvarca=false;
	public  void onClickBttnSvarca()
	{
		IsActiveSvarca = !IsActiveSvarca;
	}
	public static bool GetIsActiveSvarca(){
		return IsActiveSvarca;
	}
}
