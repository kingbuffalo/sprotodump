#!/bin/bash
lua sprotodump.lua -cs c2s.lua s2c.lua -o PrototStruct.cs
echo "copy"
cp protoT.lua /home/cds/coder/skynet/src/game/sprotocfg/
echo "finish"
