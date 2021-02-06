/** Sam Carpenter
*   Week 2
*   Enemy.cs
*   injurable fiends
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Enemy: MonoBehaviour
{
	public InjureBehavior InjureBehavior { get; set; }
	
	public int injury;
	public Text t;
    public abstract void PerformInjured();
	public abstract bool GetResistBleed();
	
	public void Awake(){
		InjureBehavior = gameObject.AddComponent<Bleed>();
	}
	
	public void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space)){
			PerformInjured();
		}else if (Input.GetKeyDown(KeyCode.Alpha1)){
			InjureBehavior = gameObject.AddComponent<Bleed>();
		}else if (Input.GetKeyDown(KeyCode.Alpha2)){
			InjureBehavior = gameObject.AddComponent<Poison>();
		}else if (Input.GetKeyDown(KeyCode.Alpha3)){
			InjureBehavior = gameObject.AddComponent<BoneShatter>();
		}
		
		this.UpdateText();
	}
	
	public virtual void UpdateText(){
		if(injury == 1){
			t.text = "The enemy is bleeding!";
		} else if(injury == 2){
			t.text = "The enemy is poisoned!";
		} else if (injury == 3){
			t.text = "The enemy's bones are broken!";
		} else{
			t.text = "The enemy is uninjured!";
		}
	}
}
