using UnityEngine;
using System.Collections;

public static class Helper
{
	public static int Clamp(this int num, int min, int max)
	{
		if(num < min) return min;
		if(num > max) return max;

		return num;
	}
}
