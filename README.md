# GMapDownloader  
这是一款用于爬取高德地图瓦片、瓦片拼接的小工具。  
用Microsoft Visual Studio Installer 2022打包的安装包已上传至release  
![image](https://github.com/hejustbrave/GMapDownloader/assets/45898487/20406c65-09df-402d-a020-df722123b1a9)
  
## 操作  
### 爬取  
####参数1.爬取级别
可手动选择或缩放底图自动选择
####参数2.瓦片范围
可直接填写经纬度范围或框选获得瓦片范围。点击框选后，在图中任意点击两点构造框选范围盒，同时右侧显示框线的瓦片范围。  

根据上述两个参数进行爬取
![image](https://github.com/hejustbrave/GMapDownloader/assets/45898487/bb4e6b1b-23b9-4f65-aa2f-842f5e68df15)  
选择输出路径，点击爬取。  
![image](https://github.com/hejustbrave/GMapDownloader/assets/45898487/7e50c83d-0b0b-4615-9ffe-3fcbfd71280e)  
###拼接	
基于WMTS的切片规则，选择指定缩放级别的地图瓦片所在的文件夹，点击拼接。  
![image](https://github.com/hejustbrave/GMapDownloader/assets/45898487/5d9eb486-7d8e-4c13-a49c-b2adfcad2d6f)  

## 框架及依赖  
.net desktop framework 6.0.25  
GMap.net2.1.6  

## 说明  
在尝试写完MapDownloadAndPuzzle后，对比查看了Github内其他的爬取工具发现自己还有很多要学习。  
学习过程中也发现了虽然很多优秀的爬取工具，但拼接工具较少，所以在此基础上开发了这款基于高德的爬取拼接工具。  
主要移除了对GDAL和python的依赖，是基于纯C#代码进行简单的爬取和拼接的学习，因此也极大程度减小了程序的体积。  
但同时拼接后的数据也只能以png的格式保存，无法保存为tif。  

## 声明  
1.本软件仅供个人学习与科研使用，所下载的数据版权归各个地图服务商所有，任何组织或个人因数据使用不当造成的问题，软件作者不负责任。  
2.框选的范围不等于最终拼接结果，因为拼接是基于爬取的瓦片，瓦片是基于框选范围所包括的所有瓦片。
