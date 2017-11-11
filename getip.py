# import socket   
# hostname=socket.gethostname()   
# print hostname
# IPAddr=socket.gethostbyname(hostname)   
# print("Your Computer Name is:"+hostname)   
# print("Your Computer IP Address is:"+IPAddr)  

# import socket
# import fcntl
# import struct

# def get_ip_address(ifname):
    # s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    # return socket.inet_ntoa(fcntl.ioctl(
        # s.fileno(),
        # 0x8915,  # SIOCGIFADDR
        # struct.pack('256s', ifname[:15])
    # )[20:24])
# print(get_ip_address(Local Area Connection))

# import socket
# mY_Ip=[l for l in ([ip for ip in socket.gethostbyname_ex(socket.gethostname())[2] \
	  # if not ip.startswith("127.")][:1], [[(s.connect(('8.8.8.8', 53)), s.getsockname()[0], s.close()) \
	  # for s in [socket.socket(socket.AF_INET, socket.SOCK_DGRAM)]][0][1]]) if l][0][0]
# print mY_Ip

import socket
def get_ip_address():
    s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    s.connect(("8.8.8.8", 80))
    return s.getsockname()[0]
print get_ip_address()