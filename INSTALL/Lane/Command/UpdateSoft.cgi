#! /bin/sh



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

echo "In EMRCV5 "
cd /EMRCV5
echo "Update EMRCV5 "
svn --username mym --password future up  --accept tf  
echo "In CONFIG "
cd /EMRCV5/CONFIG/
echo "Update Config File "
svn --username mym --password future up  --accept tf 
echo "Update Success !"



