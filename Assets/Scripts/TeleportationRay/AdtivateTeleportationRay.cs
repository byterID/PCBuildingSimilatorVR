
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class AdtivateTeleportationRay : MonoBehaviour
{
	public GameObject leftTeleportationRay;
	public GameObject rightTeleportationRay;

	public InputActionProperty leftActive;
	public InputActionProperty rightActive;

	public InputActionProperty leftCancel;
	public InputActionProperty rightCancel;

	private void Update()
	{
		leftTeleportationRay.SetActive(leftCancel.action.ReadValue<float>() == 0 && leftActive.action.ReadValue<float>() > 0.1f);
		rightTeleportationRay.SetActive(rightCancel.action.ReadValue<float>() == 0 && rightActive.action.ReadValue<float>() > 0.1f);
	}
}
