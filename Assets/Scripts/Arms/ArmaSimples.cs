using UnityEngine;
using System.Collections;

public class ArmaSimples : PartArm
{
	override public void fireWeapon()
	{
		Debug.Log("ArmaSimples: arma acionada!");
	}

	override protected void onDestroyed()
	{
		Debug.Log("ArmaSimples: destruida!");	
	}
}
