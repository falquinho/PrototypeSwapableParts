using UnityEngine;
using System.Collections;

public abstract class PartLeg : RobotPart
{
	public float move_speed;

	public Transform main_body;

	public void doMove(float h_axis, float v_axis)
	{
		Vector3 v = new Vector3(h_axis, 0f, v_axis);
		v.Normalize();

		main_body.Translate(v * move_speed * Time.deltaTime);
	}
}
