using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dance : MonoBehaviour {

	public Animator anim;
	public Button m_YourFirstButton;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		m_YourFirstButton.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TaskOnClick()
    {
        anim.SetBool("isFly", true);
        Debug.Log("fkyyyy");
    }
}
