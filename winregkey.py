from _winreg import *
import time

dicti={}
aReg = ConnectRegistry(None,HKEY_LOCAL_MACHINE)
aKey = OpenKey(aReg, r"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall")
noOfKey=QueryInfoKey(aKey)[0]
print("############################################################")
print("ERROR In Reading DisplayName of Following Keys\n")
for x in range(0,noOfKey):
    keyname = EnumKey(aKey, x)
    asubkey = OpenKey(aKey, keyname)
    try:
        val = QueryValueEx(asubkey, "DisplayName")
        dicti[keyname]=val[0]
    except Exception,e:
        print (str(keyname)+str(e))
print("############################################################\n")
        
def displayDict(obj):
    if type(obj) == dict:       
        for k, v in obj.items():
            if hasattr(v, '__iter__'):
                #print k
                displayDict(v)
            else:
                time.sleep(.1)
                print ("%s" %(v))
         
displayDict(dicti)