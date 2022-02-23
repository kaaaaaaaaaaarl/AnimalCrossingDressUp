using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropDown : MonoBehaviour {
	public Sprite[] atteluMasivs;
	public GameObject attTur;

	// Use this for initialization
	public void izkritosais(int skaitlis){
		if (skaitlis == 0)
			attTur.GetComponent<Image> ().sprite = atteluMasivs [0];
		else if (skaitlis == 1)
			attTur.GetComponent<Image> ().sprite = atteluMasivs [1];
	}
}
