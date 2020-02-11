static class SprotoFact{
	public static SprotoTypeBase GenProto(int id)
	{
		switch (id)
		{
			case 10001:
			return new SprotoType.Login();
			case 30001:
			return new SprotoType.ErrorR();
			case 20001:
			return new SprotoType.LoginR();
		}
		return null;
	}
}