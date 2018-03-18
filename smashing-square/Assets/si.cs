using UnityEngine;
using System.Collections;

public class si : MonoBehaviour {
	static int push;
	static int count;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (count >= 30) {
						Destroy (this.gameObject);
						//count = 0;
				} else
						count++;
	}
	void OnMouseOver()
	{
		if(Input.GetMouseButtonDown(0))
		   push++;
	}
}
