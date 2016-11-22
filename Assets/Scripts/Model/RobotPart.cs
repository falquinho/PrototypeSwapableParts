using UnityEngine;
using System.Collections;

public abstract class RobotPart: MonoBehaviour
{
	public ushort maxDurab;

	protected static PartsManager manager;

	protected ushort currDurab;
	protected bool broken;

	protected Skill skill;

	public void Start ()
	{
		currDurab = maxDurab;
		if (currDurab <= 0)
		{
			broken = true;
			onDestroyed();
		}
		else 
			broken = false;

		skill = GetComponent<Skill>();

		manager = transform.GetComponentInParent<PartsManager>();
		if (manager == null)
			Debug.Log("RobotPart.Start: failed to get parent PartsManager");
		else
			setSelfOnManager();
	}

	public void setManager(PartsManager m)
	{
		manager = m;
	}

	public ushort takeDamage(ushort dmg)
	{
		currDurab -= dmg;

		if (currDurab == 0)
		{
			broken = true;
			onDestroyed();
		}

		return currDurab;
	}

	public void recover(ushort amount)
	{
		currDurab += amount;
		if (currDurab > maxDurab)
			currDurab = maxDurab;

		if (currDurab > 0)
			broken = false;

	}

	public ushort getCurrentDurability()
	{
		return currDurab;
	}

	abstract protected void onDestroyed();

	abstract protected void setSelfOnManager();
}
