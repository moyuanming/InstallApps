#! /bin/sh


./HtmWriteHead

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
echo "cd /EMRCV4/BIN"
cd /EMRCV4/BIN
echo "Exec Close.sh"
./Close.sh

echo "Lane Soft Closed!"





