using UnityEngine;
using System.Collections;

public abstract class PartSupport : RobotPart
{
	public SkillPassive skill;

	public void Start()
	{
		base.Start();

		skill = GetComponent<SkillPassive>();

		if (skill == null)
			Debug.Log("PartSupport: cant find SkillPassive component!");
	}
}
