using UnityEngine;
using System.Collections;

public class PartsManager : MonoBehaviour 
{
	public GameObject torso;
	public GameObject arms;
	public GameObject legs;
	public GameObject supp;

	private Robot robot;

	public void Start()
	{
		robot = GetComponent<Robot>();

		if (robot == null)
			Debug.Log("PartsManager: ERROR: cant find component Robot");
	}

	public void setArm(GameObject obj)
	{
		if (obj.GetComponent<PartArm>() == null)
		{
			Debug.Log("PartsManager.SetArm: component not found!");
			return;
		}

		GameObject old = arms;

		arms = (GameObject)Instantiate (obj, old.transform.position, Quaternion.identity);
		arms.transform.parent = transform;

		Destroy(old);

		robot.arms = arms.GetComponent<PartArm>();
	}

	public void setTorso(GameObject obj)
	{
		if (obj.GetComponent<PartTorso>() == null)
		{
			Debug.Log("PartsManager.SetTorso: component not found!");
			return;
		}

		GameObject old = torso;

		torso = (GameObject)Instantiate (obj);
		torso.transform.parent = transform;

		Destroy(old);

		robot.torso = torso.GetComponent<PartTorso>();
	}

	public void setLegs(GameObject obj)
	{
		if (obj.GetComponent<PartLeg>() == null)
		{
			Debug.Log("PartsManager.SetLegs: component not found!");
			return;
		}

		GameObject old = legs;

		legs = (GameObject)Instantiate (obj);
		legs.transform.parent = transform;

		Destroy(old);

		robot.legs = legs.GetComponent<PartLeg>();
	}

	public void setSupport(GameObject obj)
	{
		if (obj.GetComponent<PartSupport>() == null)
		{
			Debug.Log("PartsManager.setSupport: component not found!");
			return;
		}

		GameObject old = supp;

		supp = (GameObject)Instantiate (obj);
		supp.transform.parent = transform;

		Destroy(old);

		robot.supp = supp.GetComponent<PartSupport>();
	}
}
