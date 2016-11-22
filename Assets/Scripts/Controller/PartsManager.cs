using UnityEngine;
using System.Collections;

public class PartsManager : MonoBehaviour 
{
	private PartSupport support;
	private PartArm	 	arm;
	private PartLeg		leg;
	private PartTorso	torso;

	public void setSupport(PartSupport s)
	{
		support = s;
	}

	public void setArm(PartArm a)
	{
		arm = a;
	}

	public void setLeg(PartLeg l)
	{
		leg = l;
	}

	public void setTorso(PartTorso t)
	{
		torso = t;
	}

	public PartSupport getSupport()
	{
		return support;
	}

	public PartArm getArm()
	{
		return arm;
	}

	public PartLeg getLeg()
	{
		return leg;
	}

	public PartTorso getTorso()
	{
		return torso;
	}
}
