using UnityEngine;
using System.Collections;

public class PartArm : RobotPart 
{
	public ushort firePower;

	override protected void setSelfOnManager()
	{
		manager.setArm(this);
	}

	override protected void onDestroyed()
	{
		Debug.Log("PartArm: destroyed!");
	}
}
