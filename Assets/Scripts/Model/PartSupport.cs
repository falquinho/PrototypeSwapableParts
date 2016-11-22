using UnityEngine;
using System.Collections;

public class PartSupport : RobotPart
{
	override protected void setSelfOnManager()
	{
		manager.setSupport(this);
	}

	override protected void onDestroyed()
	{
		Debug.Log("PartSupport: destroyed!");
	}
}
