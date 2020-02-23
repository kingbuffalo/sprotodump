static class SprotoFact{
	public static Sproto.SprotoTypeBase GenProto(int id,byte[] data)
	{
		switch (id)
		{
			case 30001:
			return new SprotoType.ErrorR(data);
			case 20001:
			return new SprotoType.LoginR(data);
		}
		return null;
	}

	public static ushort GetProtoId(System.Guid id)
	{
		System.Type t;

		t = typeof(SprotoType.ErrorR);
		if (t.GUID == id) return 30001;
	
		t = typeof(SprotoType.LoginR);
		if (t.GUID == id) return 20001;
	
		return 0;
	}
}