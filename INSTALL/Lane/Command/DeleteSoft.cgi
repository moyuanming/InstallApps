#! /bin/sh


./HtmWriteHead

Dt=$(date '+%Y%m%d%H%M%S')

echo "checking /EMRCV4"
Mypath=/EMRCV4
if [ ! -d "$Mypath" ]; then   
   echo "/EMRCV4 not exist!"
   echo "Please click init! "
   echo "exit !"
   exit
else
   echo "/EMRCV4 Exist!"
fi

echo "Backup Lane Soft!"
echo "cmd tar -cvf /root/EMRCV4_"$Dt".tar.gz /EMRCV4/*"
tar -cvf /root/EMRCV4_$Dt.tar.gz /EMRCV4/* 

echo "Delete Lane Soft!"
rm /EMRCV4 -rf 

echo "Lane Soft Is Deleted!!"



