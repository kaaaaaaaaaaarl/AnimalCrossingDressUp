using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teksts : MonoBehaviour {



	public string txt;
	public string age;
	public GameObject ievadesLauks;
	public GameObject tekstaAttelosana;
	public GameObject ageLauks;
	public GameObject radit;

	void Start(){
		GameObject.Find("stage1").transform.localScale = new Vector3(0, 0, 0);
	}
	public void uzglabaTxt(){
		txt = ievadesLauks.GetComponent<Text> ().text;
		age = ageLauks.GetComponent<Text> ().text;
		if (txt != "" && age != "") {
			tekstaAttelosana.GetComponent<Text> ().text = "jus esat " + txt + " ar " + age + " gadiem";
			GameObject.Find("stage1").transform.localScale = new Vector3(1, 1, 1);
		}

	}
}
