using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;

public class movementEnnemy : MonoBehaviour
{
	private Transform position;
	private int indexPos;
	private int sens;
	private SpriteRenderer spriteRenderer;
	
	// Use this for initialization
	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer> (); 
		position = GetComponent<Transform>();
		indexPos = (position.localScale.x < 0)?50:0;
		sens = (position.localScale.x < 0)?-1:1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		indexPos += 1*sens;
		position.Translate(sens*Time.deltaTime, 0, 0);
		if (indexPos == 50 )
		{
			spriteRenderer.flipX = !spriteRenderer.flipX;
			sens = -1 ;
		}
		else if (indexPos == 0)
		{
			spriteRenderer.flipX = !spriteRenderer.flipX;
			sens = 1 ;
		}
		
	}
}
