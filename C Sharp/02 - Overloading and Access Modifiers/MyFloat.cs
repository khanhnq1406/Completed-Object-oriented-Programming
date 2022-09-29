using System;

public class MyFloat
{
	private float value;
	public MyFloat()
	{
		value = 0;
	}
	public MyFloat(float input)
	{
		value=input;
	}
	public static MyFloat operator +(MyFloat a, MyFloat b)
	{
		return new MyFloat(a.value + b.value);
	}
	public static MyFloat operator -(MyFloat a, MyFloat b)
	{
		return new MyFloat(a.value - b.value);
	}
	public override string ToString()
	{
		String s = value.ToString();
		return s;
	}
}
