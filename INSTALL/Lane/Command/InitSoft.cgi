#! /bin/sh

echo "Delete EMRCV5 "
rm /EMRCV5 -rf

IP=$(ifconfig -a|grep inet|grep -v 127.0.0.1|grep -v 182.168.70.88|grep -v inet6|awk '{if(NR==1)print $2}'|tr -d "addr:")
Lane=$(echo $IP | awk -F "." '{print $4}')
Plaza=$(echo $IP | awk -F "." '{print 0$2 $3 }') 
echo "Local IP:"$IP
##ServerIP=$(echo $IP | awk -F "." '{print $1"."$2"."$3".10"}')
##SvnPath= $ServerIP/$Lane
echo "Last IP:"$Lane
echo "Exec Svn Co"

svn co --username mym --password future  --non-interactive svn://10.3.54.11/LaneSoft/EMRCV5   /EMRCV5   >>log
svn co --username mym --password future  --non-interactive svn://10.3.54.11/LaneSoft/$Plaza/$Lane/CONFIG   /EMRCV5/CONFIG  >log 

cat log
rm log 
cd /EMRCV5
svn --username mym --password future up  --accept tf  
echo "Set Execute permissions "
chmod +x BIN/*
echo "copy rc.local to etc "
cp /EMRCV5/rc.local /etc/rc.local
echo "Set Execute permissions rc.local "
chmod +x /etc/rc.local

echo "Init LaneSoft Success  "



