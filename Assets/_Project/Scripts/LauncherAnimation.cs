using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class LauncherAnimation : MonoBehaviour
{
	public Transform trigger;
	private Vector3 startTriggerPos;
	private Vector3 animTriggerPos;
	private ActionBasedController ABC;

	public GameObject bulletPrefab;
	public Transform startBulletPos;

	private void Awake()
	{
		startTriggerPos = trigger.localPosition;
		animTriggerPos = trigger.localPosition;
		animTriggerPos.z = 0.01f;
		ABC = GetComponentInParent<ActionBasedController>();
	}

	private void OnEnable()
	{
		ABC.selectAction.reference.action.performed += TriggerAction;
		ABC.selectAction.reference.action.canceled += TriggerAction;
	}

	private void OnDisable()
	{
		ABC.selectAction.reference.action.performed -= TriggerAction;
		ABC.selectAction.reference.action.canceled -= TriggerAction;
	}

	private void TriggerAction(InputAction.CallbackContext context)
	{
		if (context.performed)
		{
			trigger.localPosition = animTriggerPos;
			Instantiate(bulletPrefab, startBulletPos.position, startBulletPos.rotation);
		}
		else
		{
			trigger.localPosition = startTriggerPos;
		}
	}
}