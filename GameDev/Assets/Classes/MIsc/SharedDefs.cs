using UnityEngine;
using System.Collections;

public static class SharedDefs
{
	private static int dmgGeneric = 0;
	private static int dmgCrush = (1 << 0);
	private static int dmgClub = (1 << 1);
	private static int dmgShock = (1 << 2);
	
	public static int DMG_GENERIC
	{
		get { return dmgGeneric; }
	}
	
	public static int DMG_CRUSH
	{
		get { return dmgCrush; }
	}
	
	public static int DMG_CLUB
	{
		get { return dmgClub; }
	}
	
	public static int DMG_SHOCK
	{
		get { return dmgShock; }
	}
	
	public enum Characters
	{
		Demon,
		Laser,
		Mecha,
		Cat
	};
	
	public enum NPCs
	{
		Grunt,
		Koopa
	};
}
