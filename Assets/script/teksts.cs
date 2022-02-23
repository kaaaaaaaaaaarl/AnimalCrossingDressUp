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
	public GameObject AgeAttelosana;

	public void uzglabaTxt(){
		txt = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelosana.GetComponent<Text>().text = "vards- "+txt;
		age = ageLauks.GetComponent<Text> ().text;
		AgeAttelosana.GetComponent<Text>().text = "vecums- "+age;
	}
}
