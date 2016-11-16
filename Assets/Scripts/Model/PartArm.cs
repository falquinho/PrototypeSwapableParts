using UnityEngine;
using System.Collections;

public abstract class PartArm : RobotPart 
{
	public ushort fire_power;

	abstract public void fireWeapon();
}
