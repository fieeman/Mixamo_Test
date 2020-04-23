using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float velocidad = 5.0f;
    public float velocidad_rotacion = 200.0f;
    public float horizontal, vertical;
    private Animator anim;
    
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Rotate(0, horizontal * Time.deltaTime * velocidad_rotacion, 0);
        transform.Translate(0, 0, vertical * Time.deltaTime * velocidad);

        anim.SetFloat("Velx", horizontal);
        anim.SetFloat("Vely", vertical);


    }
}
