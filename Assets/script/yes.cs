using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class yes : MonoBehaviour{
	
	public GameObject slaideris1;
	public GameObject slaideris2;
	public GameObject mainAtt;

	public void mainiLielum(){
		float vert = slaideris2.GetComponent<Slider>().value;
		float vert2 = slaideris1.GetComponent<Slider>().value;
		mainAtt.transform.localScale = new Vector3 (1F * vert+1, 1F * vert2+1, 1);
	}
}