using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	static int count;
	static int nivel;
	static int[] cpropios;
	static int prendidos;
	static int seguros;
	int ctotal;
	static string[] cad = {"blanco","azul","rojo","verde","amarillo","morado","naranja"};
	// Use this for initialization
	void Start () {
		nivel = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (count >= 30){
			crear ();
			count=0;
		}
		else
			count++;
	}
	void niv(){
				switch (nivel) {
				case 1:
						ctotal = 2;
						cpropios [0] = Random.Range (1, 6);
						seguros = 1;
						prendidos = 2;
						break;
				default:
						return;
				}
	}
	void crear(){
			niv ();
			for(int j=0;cpropios[j] > 0;j++){
			GameObject nuevo = (GameObject)Instantiate(GameObject.Find(cad[cpropios[j]]),new Vector3(0,0,0),Quaternion.identity);
			nuevo.AddComponent("si");
			}
			for(int i=seguros; i<prendidos; i++){
			int r = Random.Range(1,ctotal);
			GameObject nuevo = (GameObject)Instantiate(GameObject.Find(cad[r]),new Vector3(0,0,0),Quaternion.identity);	
			nuevo.AddComponent("no");
			}
	}
}
