using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour {

	public GameObject zumbiPrefab;
	public float delay = 2f;
	public float area = 3f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("GerarZumbi", delay, delay);
	}

	void GerarZumbi () {
		var zumbi = Instantiate(zumbiPrefab);

		var posicaoAleatoria = Random.insideUnitCircle * area;
		zumbi.transform.position = new Vector3(
			posicaoAleatoria.x,
			zumbiPrefab.transform.position.y,
			posicaoAleatoria.y
		);
	}
}
