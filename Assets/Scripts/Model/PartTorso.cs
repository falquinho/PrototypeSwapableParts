using UnityEngine;
using System.Collections;

public class PartTorso : RobotPart 
{
	override protected void setSelfOnManager()
	{
		manager.setTorso(this);
	}

	override protected void onDestroyed()
	{
		Debug.Log("PartTorso: destroyed!");
	}
}
