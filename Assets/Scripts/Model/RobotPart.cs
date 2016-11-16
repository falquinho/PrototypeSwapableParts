using UnityEngine;
using System.Collections;

public abstract class RobotPart: MonoBehaviour
{
	public string part_name;
	public string part_description;

	public    ushort max_durab;
	protected ushort cur_durab;

	public void Start ()
	{
		cur_durab = max_durab;
	}

	public ushort takeDamage(ushort dmg)
	{
		cur_durab -= dmg;

		if (cur_durab == 0)
			onDestroyed();

		return cur_durab;
	}

	public ushort getCurrentDurability()
	{
		return cur_durab;
	}

	abstract protected void onDestroyed();
}
