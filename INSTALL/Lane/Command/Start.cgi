#! /bin/sh








#echo "checking /EMRCV4"
Mypath=/EMRCV4
if [ ! -d "$Mypath" ]; then
	./HtmWriteHead 
  echo "/EMRCV4 not exist!"
   echo "Please click init! "
   echo "exit !"
   exit
#else
 #  echo "/EMRCV4 Exist!"
fi



echo "Status:204 No Response"
echo ""
echo ""


#  "cd /EMRCV4/BIN"
cd /EMRCV4/BIN

#echo "Run Soft!"
./Run.sh & 

