using UnityEngine;
using System.Collections;

public class LoadonClick : MonoBehaviour {

	public GameObject loading;

	public void LoadScene(int lvl){
		loading.SetActive (true);
		Application.LoadLevel (lvl);
	}
}
