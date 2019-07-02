using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zumbi : MonoBehaviour {

	Animator anim;
	Rigidbody rb;
	GameObject jogador;

	public float velocidade = 0.35f;

	bool morto = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();

		jogador = GameObject.Find("Jogador");
		transform.LookAt(jogador.transform);
	}
	
	// Update is called once per frame
	void Update () {
		if (!morto)
		{
			rb.velocity = transform.forward * velocidade;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!morto && other.CompareTag("Projétil"))
		{
			morto = true;
			Destroy(other.gameObject);
			anim.SetTrigger("Morrer");
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			SceneManager.LoadScene(0);
		}
	}
}
