using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	static Vector3[] posicion = new Vector3[9];
	static int count;
	// Use this for initialization
	void Start () {
		int x=-2, y=-2,z=0,c=0;
		for(int i=0;i<3;i++){
			for(int j=0;j<3;j++){
				posicion[c] = new Vector3(x,y,z);
				x+=2;
				c++;
			}
			x=-2;
			y+=2;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(count >= 60){
			crear();
			count =0;
		}
		else
			count++;
	}
	void crear(){
		int nc = Random.Range (1, 4);
		for(int i=0;i<nc;i++){
			GameObject nuevo = (GameObject)Instantiate(GameObject.Find("azul"),posicion[Random.Range(1,9)],Quaternion.identity);
			nuevo.AddComponent<si>();

		}
	}
}
