using System;

public class User
{
	public string FirstName { get; private set; }
	public string LastName { get; private set; }
	public byte Age { get; private set; }	
	public enum Gender
	{
		Male,
		Female

	}


	public User()
	{

	}
    public User(byte age)
	{
		Age = age;
	}
}
