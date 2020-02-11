local function main(fnl,wfn)
	local intMapClass = {}
	local reg = "#(%d+)%s*%.%s*([%w_]+)%s*{"
	for _,fn in ipairs(fnl) do
		local f = io.open(fn,"r")
		local allStr = f:read("*a")
		f:close();
		for k,v in allStr:gmatch(reg) do
			intMapClass[tonumber(k)] = v
		end
	end
	local fmt = "\t\t\tcase %d:\n\t\t\treturn new SprotoType.%s();"

	local str = [[
static class SprotoFact{
	public static SprotoTypeBase GenProto(int id)
	{
		switch (id)
		{]]
	local strTail = [[
		}
		return null;
	}
}]]

	local strMidT = {str}
	for k,v in pairs(intMapClass) do
		strMidT[#strMidT+1] = string.format(fmt,k,v)
	end
	strMidT[#strMidT+1] = strTail
	local wStr = table.concat(strMidT,"\n")
	print(wStr)

	local wf = io.open(wfn,"w")
	wf:write(wStr)
	wf:flush()
	wf:close()
end

return main
--main("s2c.lua","genProto.cs")
