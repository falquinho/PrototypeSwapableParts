using UnityEngine;
using System.Collections;

public class ArmaBolada : PartArm
{
	override protected void onDestroyed()
	{
		Debug.Log("ArmaBolada: destruida!");
	}

	override public void fireWeapon()
	{
		Debug.Log("ArmaBolada: ativada!");	
	}
}
