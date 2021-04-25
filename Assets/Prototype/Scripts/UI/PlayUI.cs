using UnityEngine;
using UnityEngine.UI;

public class PlayUI : MonoBehaviour
{
    [SerializeField]
    private Text _IPText;


	private ISession _Session;

	private void Awake()
	{
		//sanity check
		Debug.Assert(_IPText != null);
	}

	private void Start()
	{
		_Session = FindObjectOfType<ISession>();

		//sanity check
		Debug.Assert(_Session);


		_IPText.text = _Session.GetIP();
	}
}