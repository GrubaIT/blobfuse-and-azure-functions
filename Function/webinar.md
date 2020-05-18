sudo apt-get install blobfuse
2 sudo nano install-dependencies.sh
3 sudo run ./install-dependencies.sh
4 ./install-dependencies.sh
5 sudo ./install-dependencies.sh
6 sudo rm ./install-dependencies.sh
7 nano install-dependencies.sh
8 ls
9 ./install-dependencies.sh
10 sudo chmod 755 install-dependencies.sh
11 sudo chown jakub:jakub install-dependencies.sh
12 ./install-dependencies.sh
13 sudo apt-get install blobfuse
14 nano mount.sh
15 rm mount.sh
16 sudo mount -t tmpfs -o size=0.5g tmpfs /mnt/ramdisk
17 sudo mkdir /mnt/resource/blobfusetmp -p
18 sudo chown jakub /mnt/resource/blobfusetmp
19 nano fuse_connection.cfg
20 chmod 600 fuse_connection.cfg
21 mkdir blob-files
22 sudo blobfuse /home/jakub/blob-files --tmp-path=/mnt/resource/blobfusetmp --config-file=/home/jakub/fuse_connection.cfg -o attr_timeout=240 -o entry_timeout=240 -o negative_timeout=120
23 sudo blobfuse /home/jakub/blob-files --tmp-path=/mnt/resource/blobfusetmp --config-file=/home/jakub/fuse_connection.cfg -o attr_timeout=240 -o entry_timeout=240 -o negative_timeout=120
24 sudo apt-get install libcurl4-gnutls-dev libgnutls28-dev
25 sudo blobfuse /home/jakub/blob-files --tmp-path=/mnt/resource/blobfusetmp --config-file=/home/jakub/fuse_connection.cfg -o attr_timeout=240 -o entry_timeout=240 -o negative_timeout=120
26 history
