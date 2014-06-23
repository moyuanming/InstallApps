echo "install vncserver"
cp vncserver /usr/bin/
cp libvncserver.so.0 /lib/
echo "cp rcloacl to etc "



rm /etc/rc.local 
ln /mnt/rc.local /etc/rc.local


echo "end"

