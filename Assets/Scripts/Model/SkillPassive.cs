using UnityEngine;
using System.Collections;

public abstract class SkillPassive : Skill 
{
	public bool active;

	abstract public bool checkCondition();
}
