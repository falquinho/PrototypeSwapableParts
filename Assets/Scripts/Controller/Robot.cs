using UnityEngine;
using System.Collections;

public class Robot: MonoBehaviour
{
	public PartTorso 	torso;
	public PartArm  	arms;
	public PartLeg   	legs;
	public PartSupport 	supp;

	public void fire()
	{
		arms.GetComponent<PartArm>().fireWeapon();
	}

	public void move(float h_axis, float v_axis)
	{
		legs.doMove(h_axis, v_axis);
	}
}
