using UnityEngine;
using System.Collections;

public class PartLeg : RobotPart
{
	public float moveSpeed;

	override protected void setSelfOnManager()
	{
		manager.setLeg(this);
	}

	public void doMove(float h_axis, float v_axis)
	{
		Vector3 v = new Vector3(h_axis, 0f, v_axis);
		v.Normalize();

		manager.transform.Translate(v * moveSpeed * Time.deltaTime);
	}

	override protected void onDestroyed()
	{
		Debug.Log("PartLeg: destroyed!");
	}
}
