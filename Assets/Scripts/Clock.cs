using System;
using UnityEngine;

public class Clock : MonoBehaviour 
{
	// 360 degrees to represent 12 hr so 360/12 = 30 degrees per hr, similarly 360 d for 60 min/sec so 360/60 = 6 d per min/sec
	const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
	
	// rotate the arm around a pivot so that arm rotates around an edge instead of its own center
	[SerializeField] private Transform hoursPivot, minutesPivot, secondsPivot;

	void Update () 
	{
		TimeSpan time = DateTime.Now.TimeOfDay;
		
		// localRotation because arms should rotate relative to its parent gameObj
		hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
		minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
		secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
	}
}