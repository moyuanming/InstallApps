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
cd /EMRCV4/CONFIG
echo "Svn Info "
svn --username mym --password future info
echo "Svn status"
svn --username mym --password future st
svn --username mym --password future ci -m "Commit lane local modfiy"



