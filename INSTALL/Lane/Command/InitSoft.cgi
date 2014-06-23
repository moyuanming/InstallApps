#! /bin/sh

rm /EMRCV5 -rf
IP=$(ifconfig -a|grep inet|grep -v 127.0.0.1|grep -v 182.168.70.88|grep -v inet6|awk '{if(NR==1)print $2}'|tr -d "addr:")
Lane=$(echo $IP | awk -F "." '{print $4}')
Plaza=$(echo $IP | awk -F "." '{print 0$2 $3 }') 
PARAMIP=$(echo $IP | awk -F "." '{print $1"."$2"."$3".1"}')
echo "Last IP:"$Lane"<br>"
echo "Exec Svn Co"
echo "" >> log
svn co --username mym --password future  --non-interactive svn://10.3.54.11/LaneSoft/EMRCV5   /EMRCV5   2>log
svn co --username mym --password future  --non-interactive svn://10.3.54.11/LaneSoft/$Plaza/$Lane/CONFIG   /EMRCV5/CONFIG  2>log
wget ftp://$PARAMIP/LDCPARAM/INIT/*  -c -t 5 -q  --directory-prefix=/EMRCV5/PARAMETER/   2>log
cat log 
cd /EMRCV5
chmod +x BIN/*
cp /EMRCV5/rc.local /etc/rc.local
chmod +x /etc/rc.local

