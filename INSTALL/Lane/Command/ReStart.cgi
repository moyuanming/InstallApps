#! /bin/sh




kill -9 `ps | grep emrc_main | awk '{print $1}'`


cd /EMRCV4/BIN

echo "Status:204 No Response"
echo ""
echo ""
./emrc_main & 
