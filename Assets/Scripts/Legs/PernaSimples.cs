using UnityEngine;
using System.Collections;

public class PernaSimples : PartLeg
{
	override protected void onDestroyed()
	{
		Debug.Log("PernaSimples: destruida!");
	}
}
