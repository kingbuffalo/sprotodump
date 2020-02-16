static class SprotoFact{
	public static Sproto.SprotoTypeBase GenProto(int id)
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

	public static ushort GetProtoId(System.Guid id)
	{
		System.Type t;

		t = typeof(SprotoType.Login);
		if (t.GUID == id) return 10001;
	
		t = typeof(SprotoType.ErrorR);
		if (t.GUID == id) return 30001;
	
		t = typeof(SprotoType.LoginR);
		if (t.GUID == id) return 20001;
	
		return 0;
	}
}