using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class HeadsUpDisplay : MonoBehaviour
{
	public AirplaneGUI plane;

	public Image fpm;
	public Image cross;

    const float cProjectionDistance = 500.0f;
	const float fProjectionDistance = 100.0f;

	// Use this for initialization
	void Start()
	{
		if (plane == null)
			Debug.LogWarning(name + ": HeadsUpDisplay has no reference plane to pull information form!");
		if (fpm == null)
			Debug.LogWarning(name + ": HeadsUpDisplay has no flight path marker to position!");
		if (cross == null)
			Debug.LogWarning(name + ": HeadsUpDisplay has no cross to position!");
	}

	// Update is called once per frame
	void Update()
	{
		if (plane != null)
		{
			Vector3 pos = Vector3.zero;

			if (cross != null)
			{
				// Put the cross some meters in front of the plane. This way the cross and FPM line up
				// correctly when there is zero angle of attack.
				pos = Camera.main.WorldToScreenPoint(plane.transform.position + (plane.transform.forward.normalized * cProjectionDistance));
				//pos.z = 0.0f;
				cross.transform.position = pos;
			}

			if (fpm != null)
			{
				// Put the cross some meters in front of the plane. This way the cross and FPM line up
				// correctly when there is zero angle of attack.
				pos = Camera.main.WorldToScreenPoint(plane.transform.position + (plane.transform.forward.normalized * fProjectionDistance));
				//pos.z = 0.0f;
				fpm.transform.position = pos;
			}
		}
	}
}
