#!/bin/bash
lua sprotodump.lua -cs c2s.lua s2c.lua -o ProtoStruct.cs
echo "copy"
cp protoT.lua /home/cds/coder/skynet/src/game/sprotocfg/
cp c2s.lua /home/cds/coder/skynet/src/game/sprotocfg/
cp s2c.lua /home/cds/coder/skynet/src/game/sprotocfg/
echo "finish"
sz c2s.lua
sz s2c.lua
sz SprotoFact.cs
sz ProtoStruct.cs
sz CmdConst.cs
