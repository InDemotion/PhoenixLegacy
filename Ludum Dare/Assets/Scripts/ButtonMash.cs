using UnityEngine;
using System.Collections;

public class ButtonMash : MonoBehaviour {

	private int inputnumber;
	private bool Timelock = false;

	void Start () {
		//démarer la coroutine de 10 secondes
	}

	void Update () {
		if (Input.GetKeyDown("A") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("Z") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("E") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("R") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("T") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("Y") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("U") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("I") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("O") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("P") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("Q") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("S") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("D") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("F") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("G") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("H") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("J") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("K") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("L") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("M") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("W") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("X") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("C") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("V") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("B") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("N") && Timelock == false)
			inputnumber++;
		if (Input.GetKeyDown("Space") && Timelock == false)
			inputnumber++;
	}
}
