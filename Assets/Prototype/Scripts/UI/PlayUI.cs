using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayUI : MonoBehaviour
{
    [SerializeField]
    private Text _IPText;

	[SerializeField]
	private RectTransform _ChatContent;

	[SerializeField]
	private int _ChatHistoryCount = 256;

	private ISession _Session;

	private Queue<RectTransform> _ChatHistory;

	private void Awake()
	{
		//sanity check
		Debug.Assert(_IPText != null);
		Debug.Assert(_ChatContent != null);

		_ChatHistory = new Queue<RectTransform>();
	}

	private void Start()
	{
		var chatChildCount = _ChatContent.childCount;
		for (int i = 0; i < chatChildCount; i++)
		{
			var child = _ChatContent.GetChild(i);
			//sanity check
			if(child is RectTransform == false || child.GetComponent<Text>() == null)
			{
				Destroy(child.gameObject);
			}

			_ChatHistory.Enqueue(child as RectTransform);
		}

		_Session = FindObjectOfType<ISession>();

		//sanity check
		Debug.Assert(_Session);


		_IPText.text = _Session.GetIP();
	}

	private void LateUpdate()
	{
		
	}

	private void AddToChat()
	{

	}

	private void RemoveOldChat()
	{
		while(_ChatHistory.Count > _ChatHistoryCount)
		{
			var chatChild = _ChatHistory.Dequeue();
			//TODO : put this in a Object pool
			Destroy(chatChild.gameObject);
		}
	}
}