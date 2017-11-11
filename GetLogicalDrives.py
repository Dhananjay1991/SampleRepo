import win32api

drives = win32api.GetLogicalDriveStrings()
print drives
drives = drives.split('\000')[:-1]
print drives

import win32com.client

wmi = win32com.client.GetObject ("winmgmts:")
for usb in wmi.InstancesOf ("Win32_USBHub"):
    print usb.DeviceID