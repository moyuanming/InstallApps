echo "install vncserver"
cp /mnt/vncserver /usr/bin/
cp /mnt/libvncserver.so.0 /lib/
echo "cp rcloacl to etc "



#rm /etc/rc.local 
cp /mnt/rc.local /etc/rc.local


echo "end"

