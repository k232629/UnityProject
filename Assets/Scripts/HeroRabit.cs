﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRabit : MonoBehaviour {

	bool isGrounded = false;
	bool JumpActive = false;
<<<<<<< HEAD
<<<<<<< HEAD
	bool bigRabit = false;
	bool smallRabit = false;
	bool rabit = true;
=======
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
=======
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
	float JumpTime = 0f;
	public float MaxJumpTime = 2f;
	public float JumpSpeed = 2f;
	
	public float speed = 1;
<<<<<<< HEAD
<<<<<<< HEAD
	Transform heroParent = null;
=======
	
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
=======
	
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
	
	Rigidbody2D myBody = null;
	SpriteRenderer sr = null;
	// Use this for initialization
	void Start () {
<<<<<<< HEAD
<<<<<<< HEAD
		//Зберегти стандартний батьківський GameObject
		this.heroParent = this.transform.parent;
=======
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
=======
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
		myBody = this.GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer>();
		LevelController.current.setStartPosition (transform.position);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		//[-1, 1]

		Vector3 from = transform.position + Vector3.up * 0.3f;
		Vector3 to = transform.position + Vector3.down * 0.1f;
		int layer_id = 1 << LayerMask.NameToLayer ("Ground");
		//Перевіряємо чи проходить лінія через Collider з шаром Ground
		RaycastHit2D hit = Physics2D.Linecast(from, to, layer_id);
		if(hit) {
			isGrounded = true;
		} else {
			isGrounded = false;
		}
		//Намалювати лінію (для розробника)

<<<<<<< HEAD
<<<<<<< HEAD
		//Згадуємо ground check
		if(hit) {
			if(hit.transform != null && hit.transform.GetComponent<MovingPlatform>() != null){
				//Приліпаємо до платформи
				SetNewParent(this.transform, hit.transform);
			}
		} else {
			//Ми в повітрі відліпаємо під платформи
			SetNewParent(this.transform, this.heroParent);
		}

=======
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
=======
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
		if(Input.GetButtonDown("Jump") && isGrounded) {
			this.JumpActive = true;
		}
		if(this.JumpActive) {
			//Якщо кнопку ще тримають
			if(Input.GetButton("Jump")) {
				this.JumpTime += Time.deltaTime;
				if (this.JumpTime < this.MaxJumpTime) {
					Vector2 vel = myBody.velocity;
					vel.y = JumpSpeed * (1.0f - JumpTime / MaxJumpTime);
					myBody.velocity = vel;
				}
			} else {
		this.JumpActive = false;
		this.JumpTime = 0;
		}
}
		float value = Input.GetAxis ("Horizontal");
		Animator animator = GetComponent<Animator> ();

		if (Mathf.Abs (value) > 0) {
			Vector2 vel = myBody.velocity;
			vel.x = value * speed;
			myBody.velocity = vel;
		}

		if(value < 0) {
			sr.flipX = true;
		} else if(value > 0) {
			sr.flipX = false;
		}

		if(Mathf.Abs(value) > 0) {
			animator.SetBool ("run", true);
		} else {
			animator.SetBool ("run", false);
		}
		if(this.isGrounded) {
			animator.SetBool ("jump", false);
		} else {
			animator.SetBool ("jump", true);
		}
<<<<<<< HEAD
<<<<<<< HEAD


=======
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
=======
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
	
	}


<<<<<<< HEAD
<<<<<<< HEAD
	static void SetNewParent(Transform obj, Transform new_parent) {
		if(obj.transform.parent != new_parent) {
			//Засікаємо позицію у Глобальних координатах
			Vector3 pos = obj.transform.position;
			//Встановлюємо нового батька
			obj.transform.parent = new_parent;
			//Після зміни батька координати кролика зміняться
			//Оскільки вони тепер відносно іншого об’єкта
			//повертаємо кролика в ті самі глобальні координати
			obj.transform.position = pos;
	}
}


	public void becomeBigger(){
			this.transform.localScale = Vector3.one * 2;
			this.rabit=false;
			this.bigRabit=true;
			this.smallRabit=false;
	}

	public void bombAction(){
		Animator animator = GetComponent<Animator> ();
		if(this.rabit){
			becomeBigger();
			
		}
		if(this.bigRabit){
			this.transform.localScale = Vector3.one;
			this.smallRabit=true;
			this.bigRabit=false;
			this.rabit=false;
		}

		if(this.smallRabit&&!this.rabit&&!this.bigRabit){
			animator.SetBool ("die",true);
			LevelController.current.onRabitDeath(this);
			animator.SetBool ("die",false);
		}
	}


=======
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
=======
>>>>>>> 3b17b88c3ff8ea3809bdc46d4609a1d92c6cf50d
	
}
