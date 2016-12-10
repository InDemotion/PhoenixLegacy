using UnityEngine;
using System.Collections;

public class Postit : MonoBehaviour {

	private int pasted;
	private int color;
	private bool Softlock;
	private GameObject postit;
	public GameObject Rpostit;
	public GameObject Gpostit;
	public GameObject Bpostit;
	public GameObject Ypostit;
	public GameObject Ppostit;

	void Update()
	{
		if (pasted < 20 && Input.GetButtonDown("Click"))
			{
			if (color == 5) {
				color = 1;
				Instantiate (Rpostit, transform.position, Quaternion.identity);
				return;
			}
			if (color == 1) {
				color++;
				Instantiate (Gpostit, transform.position, Quaternion.identity);
				return;
			}
			if (color == 2) {
				color++;
				Instantiate (Bpostit, transform.position, Quaternion.identity);
				return;
			}
			if (color == 3) {
				color++;
				Instantiate (Ypostit, transform.position, Quaternion.identity);
				return;
			}
			if (color == 4) {
				color++;
				Instantiate (Ppostit, transform.position, Quaternion.identity);
				pasted++;
				return;
			}
		}
		if (pasted >= 20 && Softlock == false) {
			Softlock = true;
			color = Random.Range (1, 5);
			if (color == 1)
				PlayerPrefs.SetInt("Postit.color",1);
			if (color == 2)
				PlayerPrefs.SetInt("Postit.color",2);
			if (color == 3)
				PlayerPrefs.SetInt("Postit.color",3);
			if (color == 4)
				PlayerPrefs.SetInt("Postit.color",4);
			if (color == 5)
				PlayerPrefs.SetInt("Postit.color",5);
		}
	}
}
