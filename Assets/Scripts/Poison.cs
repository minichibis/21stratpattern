/** Sam Carpenter
*   Week 2
*   Poison.cs
*   make em melt
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison: MonoBehaviour, InjureBehavior
{
    public void injure(Enemy e){
		e.injury = 2;
	}
}

