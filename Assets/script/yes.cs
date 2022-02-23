using System.Collections;
using UnityEngine;

class yes : MonoBehaviour
{
	private Color mouseOverColor = Color.blue;
	private Color originalColor = Color.yellow;
	private bool dragging = false;
	private float distance;
	private Vector3 starDist;




	void OnMouseDown()
	{
		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
		dragging = true;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Vector3 rayPoint = ray.GetPoint(distance);
		starDist = transform.position - rayPoint;
	}

	void OnMouseUp()
	{
		dragging = false;
	}

	void Update()
	{
		if (dragging)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 rayPoint = ray.GetPoint(distance);
			transform.position = rayPoint + starDist;
		}
	}
}