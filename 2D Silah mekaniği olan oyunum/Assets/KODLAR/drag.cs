﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
	float uzaklık = 16.20f;
	void OnMouseDrag()
	{
		Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, uzaklık);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
		transform.position = objPosition;
	}
}
