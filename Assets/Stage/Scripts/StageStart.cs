using UnityEngine;
using System.Collections;

public class StageStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGameStartBtnClicked()
	{
		Application.LoadLevel("stage1");
	}
}
