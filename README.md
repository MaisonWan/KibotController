## Ark Controller
Ark Controller是基于adb封装的Android控制器，运行在Windows系统之上。详情查看[GitHub Page](https://maisonwan.github.io/ArkController/) 

![image](images/screenshot.png)


### 连接设备
等待设备连接，获取可以连接设备列表

```connect
等待设备连接
adb wait-for-device devices

重启adb
adb kill-server
adb start-server
```

### 设备信息
设备信息包括，设备编码、名称、日期、分辨率、当前应用、输入法和屏幕截图。

```deviceinfo
屏幕截图
adb shell screencap -p <device_path>     -device_path设备路径

屏幕录制
shell screenrecord --size <size>  --time-limit <limit> --verbose <path>

拉取文件
adb pull <device_path> <local>   -device_path设备路径, local本地路径

电池信息
adb shell dumpsys battery

设备日期
adb shell date

当前应用
adb shell dumpsys activity | grep "mFocusedActivity"

系统输入法
adb shell ime list [-a] [-s]
-a 查看所有输入法
-s 简要信息.

获取屏幕像素密度
adb shell wm density

获取屏幕分辨率
adb shell wm size

设置屏幕像素密度
adb shell wm density <density>     -density像素密度

设置屏幕分辨率
adb shell wm size <width>x<height>    -width，height屏幕宽高

重置屏幕分辨率
adb shell wm size reset
```

### 按键控制
模拟系统按键，常用返回、主页、电源，重启，声音按键，以及字母和数字按键的模拟。

```key
模拟按键输入
adb shell input keyevent <keycode>     -keycode按键的编码

模拟输入文本
adb shell input text <"text">     -text即为要输入的文本

重启系统
adb reboot [bootloader|recovery]   -重启设备, 直接进入到bootloader或者recovery模式
```

### 应用列表
获取设备上安装的应用列表，按照类型过滤，应用包名过滤。

```programlist
获取应用列表
adb shell pm list package [-f] [-i] [-s] [-3]    
'-f' 安装位置
'-i' 程序类型
'-s' 系统程序
'-3' 第三方程序

打开应用详细信息
adb shell am start -a android.settings.APPLICATION_DETAILS_SETTINGS -d package:<package>

清空应用数据
adb shell pm clear <package>

获取应用信息
adb shell dumpsys package <package>

获取设备详细信息
adb shell pm dump <package>

杀掉当前应用进程
adb shell am force-stop <package>

隐藏应用
adb shell pm hide <package>

恢复应用
adb shell pm unhide <package>

安装应用
adb install [-l] [-r] [-s] <file>
'-l' 锁定该程序
'-r' 重新安装该程序，保存数据
'-s' 安装在SD卡内，而不是设备内部存储

卸载应用
adb uninstall [-k] <package>
'-k' 不删除程序运行所产生的数据和缓存目录(如软件的数据库文件)
```

### 进程列表
查看进程列表，进程类型，杀掉进程

```ps
获取进程
adb shell ps
```

### 性能监测
监测应用对于CPU和内存占用

```cpu
adb shell top [-m] <num> [-d] <interval> -s <sortcol> [-t]
'-m' 显示的进程数量
'-d' 刷新的间隔时间
'-s' 排序的列名，支持cpu，vss，rss，thr
'-t' 是否显示线程信息

对于单个进程的内存占用监测，使用了命令
adb shell dumpsys meminfo <process>
process 进程名
```

### Logcat
控制输出logcat的日志和过滤

```logcat
过滤logcat输出
adb logcat -v time *:[level] -level包含 V，D，I，W，E，F，S，分别代表不同级别的log
```

### 系统属性
查看系统内部的属性

```pro
adb shell getprop
```

### 文件管理
系统文件管理，使用的命令

```file
显示文件列表
adb shell ls [-a] [-l] <path>
'-a' 显示隐藏文件
'-l' 文件列表

删除文件
adb shell rm [-r] <filepath>
'-r' 删除文件夹以及里面的文件

重命名文件
adb shell rename <oldpath> <newpath>
```

### 打开系统内置界面
使用命令adb shell am start -a [action] action主要支持的如下：

```open-action
android.settings.AIRPLANE_MODE_SETTINGS
android.settings.APN_SETTINGS
android.settings.APPLICATION_DEVELOPMENT_SETTINGS
android.settings.APPLICATION_SETTINGS
android.settings.BLUETOOTH_SETTINGS
android.settings.DATA_ROAMING_SETTINGS
android.settings.DATE_SETTINGS
android.settings.DISPLAY_SETTINGS
android.settings.INPUT_METHOD_SETTINGS
android.settings.INTERNAL_STORAGE_SETTINGS
android.settings.LOCALE_SETTINGS
android.settings.LOCATION_SOURCE_SETTINGS
android.settings.MANAGE_APPLICATIONS_SETTINGS
android.settings.MEMORY_CARD_SETTINGS
android.settings.NETWORK_OPERATOR_SETTINGS
android.settings.QUICK_LAUNCH_SETTINGS
android.settings.SECURITY_SETTINGS
android.settings.SETTINGS
android.settings.SOUND_SETTINGS
android.settings.SYNC_SETTINGS
android.settings.USER_DICTIONARY_SETTINGS
android.settings.WIFI_IP_SETTINGS
android.settings.WIFI_SETTINGS
android.settings.WIRELESS_SETTINGS
```

### 支持
为了解决异步与adb通信的问题，该程序中仿照Android中Handler与Looper的机制，设计了一套异步消息队列的架构，解决了点击和处理速度不同造成的背压问题，但是暂时还没解决消息插队的问题，如果有其他好的建议，欢迎拍砖 [maisonwan@gmail.com](mailto://maisonwan@gmail.com)
