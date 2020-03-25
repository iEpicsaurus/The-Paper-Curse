using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
	Transform menuPanel;
	Event keyEvent;
	Text buttonText;
	KeyCode newKey;

	bool waitingForKey;


	void Start()
	{
		// menuPanel would be our Panel
		menuPanel = transform.Find("Panel");
		menuPanel.gameObject.SetActive(false);
		waitingForKey = false;

		// find button's text in Canvas items
		for (int i = 0; i < menuPanel.childCount; i++)
		{
			if (menuPanel.GetChild(i).name == "LeftKey")
				menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.left.ToString();
			else if (menuPanel.GetChild(i).name == "RightKey")
				menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.right.ToString();
			else if (menuPanel.GetChild(i).name == "JumpKey")
				menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.jump.ToString();
		}
	}


	void Update()
	{
		
	}

	//check what we are pressing on keyboard
	void OnGUI()
	{
		
		keyEvent = Event.current;

		
		if (keyEvent.isKey && waitingForKey)
		{
			newKey = keyEvent.keyCode; 
			waitingForKey = false;
		}
	}

	
	public void StartAssignment(string keyName)
	{
		// we pree the new button to be assigned to moving left or right or jumping, this waits for the key press
		if (!waitingForKey)
			StartCoroutine(AssignKey(keyName));
	}

	
	public void SendText(Text text)
	{
		buttonText = text;
	}

	
	IEnumerator WaitForKey()
	{
		while (!keyEvent.isKey)
			yield return null;
	}

	
	public IEnumerator AssignKey(string keyName)
	{
		waitingForKey = true;

		yield return WaitForKey(); 

		switch (keyName)
		{

			case "left":
				// reassigning left button
				GameManager.GM.left = newKey; 
				buttonText.text = GameManager.GM.left.ToString(); /
				PlayerPrefs.SetString("leftKey", GameManager.GM.left.ToString());
				break;
			case "right":
				// reassigning right button
				GameManager.GM.right = newKey; 
				buttonText.text = GameManager.GM.right.ToString(); 
				PlayerPrefs.SetString("rightKey", GameManager.GM.right.ToString()); 
				break;
			case "jump":
				// reassigning jump button
				GameManager.GM.jump = newKey; 
				buttonText.text = GameManager.GM.jump.ToString(); 
				PlayerPrefs.SetString("jumpKey", GameManager.GM.jump.ToString()); 
				break;
		}

		yield return null;
	}
}