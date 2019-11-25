using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSvarca : MonoBehaviour {
	[SerializeField]  GameObject[] Compound;
	[SerializeField]  GameObject Seam;
	[SerializeField]GameObject VannaSeam;
	[SerializeField]  int I,D,S,U;

	public  GameObject[]GetCompound(){
		return Compound;}
	public  GameObject GetSeam(){
		return Seam;
	}
	public  int getI(){
		return I;}
	public  int getD(){
		return D;}
	public  int getS(){
		return S;}
	public  int getU(){
		return U;}
	public GameObject GetVannaSeam(){
		return VannaSeam;
	}
}
