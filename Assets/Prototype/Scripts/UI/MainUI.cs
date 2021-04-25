using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
	[SerializeField]
    private Button _ServerButton;
    
	[SerializeField]
	private Button _ClientButton;
	
	[SerializeField]
	private InputField _IPInput;

	[SerializeField]
	private ServerSession _ServerSession;
	[SerializeField]
	private ClientSession _ClientSession;

	private void Awake()
	{
		//sanity check
		Debug.Assert(_ServerButton != null);
		Debug.Assert(_ClientButton != null);
		Debug.Assert(_IPInput != null);

		Debug.Assert(_ServerSession != null);
		Debug.Assert(_ClientSession != null);
	}

	private void Start()
	{
		_ServerButton.onClick.AddListener(OnServerButtonClick);
		_ClientButton.onClick.AddListener(OnClientButtonClick);
	}

	private void OnClientButtonClick()
	{
		_ClientSession.Connect(_IPInput.text);
		gameObject.SetActive(false);
	}

	private void OnServerButtonClick()
	{
		_ServerSession.StartServer();
		gameObject.SetActive(false);
	}

}