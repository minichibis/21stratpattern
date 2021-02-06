/** Sam Carpenter
*   Week 2
*   Bleed.cs
*   cut the flesh (note: only works on flesh)
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bleed : MonoBehaviour, InjureBehavior
{
    public void injure(Enemy e){
		if(!e.GetResistBleed()){
			e.injury = 1;
		}else{
			e.injury = 0;
		}
	}
}
