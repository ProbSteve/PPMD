using UnityEngine;
using System.Collections;
using System;
using CodeMonkey.Utils;

public abstract class Action : MonoBehaviour
{
	public virtual bool ExecuteAction(GameObject other)
	{
		//the return value indicates if the action has been successful
		//some actions always return true
		return true;
	}

    public static implicit operator Action(System.Action v)
    {
        throw new NotImplementedException();
    }

    public static implicit operator Action(FunctionUpdater v)
    {
        throw new NotImplementedException();
    }
}
