# Lianjia_spider

#### 介绍
一个简单的多线程爬虫，主要是抓取 链家https://www.lianjia.com/ 的房源信息，可实现多线程多任务采集。同时可以将采集的信息存入本地文件和MySQL数据库。
还不是很完善，欢迎大家讨论。

#### 演示视频

https://www.bilibili.com/video/BV1DZ4y1A7gT

#### 软件架构
软件架构说明

开发语言：C#    winform

IDE：visual studio 2017

数据库：MySQL8.0


#### 安装教程

1. 要想运行本软件，需要修改项目中的数据库字连接符串，修改为自己主机的MySQL信息，以及需要修改保存采集信息的文件目录。【当然也可以把存数据库的模块砍掉，直接存文件】

#### 运行截图

主界面
![输入图片说明](https://github.com/abin-z/Lianjia_spider/blob/3e70b1d52305c0f2ada8f52ff64aadb6e975f2d3/src/img/page1.png)

创建任务界面
![输入图片说明](https://gitee.com/abin_z/lianjia_spider/raw/master/img/page2.png "创建任务")

运行界面（欢迎页）
![输入图片说明](https://gitee.com/abin_z/lianjia_spider/raw/master/img/page3.png "欢迎页")

已完成界面（欢迎页）
![输入图片说明](https://gitee.com/abin_z/lianjia_spider/raw/master/img/page4.png "欢迎页")

运行界面
![输入图片说明](https://gitee.com/abin_z/lianjia_spider/raw/master/img/page7.png "正在运行页")

已完成界面
![输入图片说明](https://gitee.com/abin_z/lianjia_spider/raw/master/img/page8.png "已完成界面")

本地文件（可直接用Excel打开）
![输入图片说明](https://gitee.com/abin_z/lianjia_spider/raw/master/img/page9.png "csv本地文件")

#### 使用说明

1.  本软件实在屏幕缩放为150%下构建的界面，在屏幕缩放不为150%的情况下可能会出现界面混乱。
2.  演示视频：https://www.bilibili.com/video/BV1DZ4y1A7gT
