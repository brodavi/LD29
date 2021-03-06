using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	void Start () {
		renderer.material.color = Color.cyan;
		renderer.transform.localScale = new Vector2(0.5f, 0.5f);
	}
	
	void Update () {

		if(StartPauseMenu.Paused)
		{
			return;
		}

		if(!Input.GetKey(KeyCode.Space))
		{
			return;
		}

		if(Map.Player == null)
		{
			return;
		}

		int playerX = Mathf.RoundToInt(Map.Player.transform.position.x);
		int playerY = Mathf.RoundToInt(Map.Player.transform.position.y);

		int x = Mathf.RoundToInt(transform.position.x);
		int y = Mathf.RoundToInt(transform.position.y);

		if(x != playerX)
		{
			return;
		}

		if(y != playerY)
		{
			return;
		}

		StoryWindows.isEnabled = true;

		Destroy(gameObject);
	}
}