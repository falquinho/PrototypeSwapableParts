using UnityEngine;
using System.Collections;

public class RobotController : MonoBehaviour 
{
	public Robot robot;
	public PartsManager manager;

	public GameObject[] swap_arm;
	private int curr_arm;

	void Start()
	{
		curr_arm = 0;
	}
	
	void Update () 
	{
		if (Input.GetButtonDown("Fire1"))
			robot.fire();

		robot.move(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

		// testing instantiating
		if (Input.GetButtonDown("Fire2"))
		{
			curr_arm ++;
			curr_arm = curr_arm % 2;

			manager.setArm(swap_arm[curr_arm]);
		}
	}
}
