#! /bin/sh


./HtmWriteHead

echo "checking /EMRCV5"
Mypath=/EMRCV5
if [ ! -d "$Mypath" ]; then
   echo "/EMRCV5 not exist!"
   echo "Please click init! "
   echo "exit !"
   exit
else
   echo "/EMRCV5 Exist!"
fi

cd /EMRCV5
svn --username mym --password future up  --accept tf  
cd /EMRCV5/CONFIG/
svn --username mym --password future up  --accept tf 



