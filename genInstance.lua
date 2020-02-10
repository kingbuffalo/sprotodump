local function main(fn)
	local f = io.open(fn,"r")
	local allStr = f:read("*a")
	f:close();
	--print(allStr)
	--local reg = "#(%d+)%s*.*%s*%.%s([%w_]+)%s{"
	local reg = "#(%d+)%s*%.%s*([%w_]+)%s*{"
	for k,v in allStr:gmatch(reg) do
		print( k )
		print( v )
	end
end

main("s2c.lua")
main("c2s.lua")
