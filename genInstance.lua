local function genIntMapClass(fnl)
	local intMapClass = {}
	local reg = "#(%d+)%s*%.%s*([%w_]+)%s*{"
	for _,fn in ipairs(fnl) do
		local f = io.open(fn,"r")
		local allStr = f:read("*a")
		f:close();
		for k,v in allStr:gmatch(reg) do
			if intMapClass[tonumber(k)] ~= nil then
				assert(false,"k= " .. k .. " redefine")
			else
				intMapClass[tonumber(k)] = v
			end
		end
	end
	return intMapClass
end

local function writeCSharpIntToClassClassToInt(intMapClass,wfn)
	local fmt = "\t\t\tcase %d:\n\t\t\treturn new SprotoType.%s(data);"
	local str = [[
static class SprotoFact{
	public static Sproto.SprotoTypeBase GenProto(int id,byte[] data)
	{
		switch (id)
		{]]
	local strTail = [[
		}
		return null;
	}
]]

	local str2 = [[
	public static ushort GetProtoId(System.Guid id)
	{
		System.Type t;
]]
	local fmt2 = [[
		t = typeof(SprotoType.%s);
		if (t.GUID == id) return %d;
	]]
	local str2tail = [[
		return 0;
	}
}]]
--}]]

	local strMidT = {str}
	for k,v in pairs(intMapClass) do
		strMidT[#strMidT+1] = string.format(fmt,k,v)
	end
	strMidT[#strMidT+1] = strTail

	strMidT[#strMidT+1] = str2
	for k,v in pairs(intMapClass) do
		strMidT[#strMidT+1] = string.format(fmt2,v,k)
	end
	strMidT[#strMidT+1] = str2tail

	local wStr = table.concat(strMidT,"\n")

	local wf = io.open(wfn,"w")
	wf:write(wStr)
	wf:flush()
	wf:close()
end

local function writeCSharpCmdConst(intMapClass)
	local str1 = [[namespace game.data{
	static class CmdConst{
%s
	}
}
	]]
	local midFmt = "\t\tpublic static int %s = %d;"
	local strT = {}
	for k,v in pairs(intMapClass) do
		strT[#strT+1] = string.format(midFmt,v,k)
	end
	local str = table.concat(strT,"\n")
	local wStr = string.format(str1,str)
	print(wStr)
	local wf = io.open("CmdConst.cs","w")
	wf:write(wStr)
	wf:flush()
	wf:close()
end

local function writeLuaStrToInt(intMapClass)
	local luaFmt = "\t[%d]=\"%s\","
	local luavkFmt = "\t%s=%d,"
	local luastrT = {"return {"}
	for k,v in pairs(intMapClass) do
		luastrT[#luastrT+1] = string.format(luaFmt,k,v)
		luastrT[#luastrT+1] = string.format(luavkFmt,v,k)
	end
	luastrT[#luastrT+1] = "}"
	wStr = table.concat(luastrT,"\n")
	local wf = io.open("protoT.lua","w")
	wf:write(wStr)
	wf:flush()
	wf:close()
end


local function main(fnl,wfn)
	local intMapClass = genIntMapClass(fnl)
	writeCSharpIntToClassClassToInt(intMapClass,wfn)
	writeLuaStrToInt(intMapClass)
	writeCSharpCmdConst(intMapClass)
end

return main
--main({"s2c.lua"},"genProto.cs")
