static class SprotoFact{
	public static Sproto.SprotoTypeBase GenProto(int id,byte[] data)
	{
		switch (id)
		{
			case 10001:
			return new SprotoType.Login(data);
			case 31002:
			return new SprotoType.MatchAckP(data);
			case 21001:
			return new SprotoType.MatchR(data);
			case 11002:
			return new SprotoType.MatchAckCP(data);
			case 31001:
			return new SprotoType.MatchP(data);
			case 11001:
			return new SprotoType.Match(data);
			case 1001:
			return new SprotoType.MatchPlayer(data);
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

		t = typeof(SprotoType.Login);
		if (t.GUID == id) return 10001;
	
		t = typeof(SprotoType.MatchAckP);
		if (t.GUID == id) return 31002;
	
		t = typeof(SprotoType.MatchR);
		if (t.GUID == id) return 21001;
	
		t = typeof(SprotoType.MatchAckCP);
		if (t.GUID == id) return 11002;
	
		t = typeof(SprotoType.MatchP);
		if (t.GUID == id) return 31001;
	
		t = typeof(SprotoType.Match);
		if (t.GUID == id) return 11001;
	
		t = typeof(SprotoType.MatchPlayer);
		if (t.GUID == id) return 1001;
	
		t = typeof(SprotoType.ErrorR);
		if (t.GUID == id) return 30001;
	
		t = typeof(SprotoType.LoginR);
		if (t.GUID == id) return 20001;
	
		return 0;
	}
}