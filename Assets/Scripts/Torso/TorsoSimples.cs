using UnityEngine;
using System.Collections;

public class TorsoSimples : PartTorso 
{
	override protected void onDestroyed()
	{
		Debug.Log("TorsoSimples: destruido!");
	}
}
