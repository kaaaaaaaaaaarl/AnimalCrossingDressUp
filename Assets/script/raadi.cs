using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raadi : MonoBehaviour {
	public GameObject bikses;
	public GameObject cepures;
	public GameObject kleitas;
	public GameObject krekli;

	// Use this for initialization
	void Start(){
		bikses.transform.localScale = new Vector3(0, 0, 0);
		cepures.transform.localScale = new Vector3(0, 0, 0);
		kleitas.transform.localScale = new Vector3(0, 0, 0);
		krekli.transform.localScale = new Vector3(0, 0, 0);
	


	}
	public void bikse(bool ver){
		bikses.transform.localScale = new Vector3(1,1, 1);
		cepures.transform.localScale = new Vector3(0, 0, 0);
		kleitas.transform.localScale = new Vector3(0, 0, 0);
		krekli.transform.localScale = new Vector3(0, 0, 0);
	}

	public void cepur(bool ver){
		bikses.transform.localScale = new Vector3(0, 0, 0);
		cepures.transform.localScale = new Vector3(1,1, 1);
		kleitas.transform.localScale = new Vector3(0, 0, 0);
		krekli.transform.localScale = new Vector3(0, 0, 0);
	}
	public void kleit(bool ver){
		bikses.transform.localScale = new Vector3(0, 0, 0);
		cepures.transform.localScale = new Vector3(0, 0, 0);
		kleitas.transform.localScale = new Vector3(1,1, 1);
		krekli.transform.localScale = new Vector3(0, 0, 0);
	}
	public void krekl(bool ver){
		krekli.transform.localScale = new Vector3(1,1, 1);
		bikses.transform.localScale = new Vector3(0, 0, 0);
		cepures.transform.localScale = new Vector3(0, 0, 0);
		kleitas.transform.localScale = new Vector3(0, 0, 0);
	
	}
}
