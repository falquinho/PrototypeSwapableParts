using UnityEngine;
using System.Collections;

public abstract class SkillActive : Skill
{
	public float cooldown;
	public float curr_cd;

	public bool ready;

	public void Start()
	{
		curr_cd = cooldown;
		ready = true;
	}

	public void Update()
	{
		if (!ready)
		{
			curr_cd += Time.deltaTime;
			if (curr_cd >= cooldown)
				ready = !ready;
		}
	}

	abstract public void activate();
}
