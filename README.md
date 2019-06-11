[![Build Status](https://travis-ci.org/ZhaoQi99/EasyLife.svg?branch=Course_Design)](https://travis-ci.org/ZhaoQi99/EasyLife/tree/Course_Design)
[![Release](https://img.shields.io/github/release/ZhaoQi99/EasyLife.svg)](https://github.com/ZhaoQi99/EasyLife/releases)
[![License](https://img.shields.io/badge/license-GPL--3.0-blue.svg)](https://github.com/ZhaoQi99/EasyLife/blob/Course_Design/LICENSE)
# EasyLife V0.1.0

## 软件开发工具
系统开发平台: Microsoft Visual Studio 2015

系统开发语言:C#

数据库管理软件: Microsoft  Access 2016

版本控制软件:Git

持续集成服务:Travis CI

软件体系架构:三层架构

## 获取帮助
[EasyLife V0.1.0帮助文档](https://zhaoqi99.github.io/EasyLife/V0.1.0/help.html)

## 基本功能
1.	显示天气及生活指数:
自动通过本机Ip地址获取当前地理位置，并自动在主页上显示:当天的气温，概况，风向和风力，天气趋势开始图片，天气趋势结束图片，现在的天气实况，天气和生活指数。第二天、第三天的气温，概况，风向和风力，天气趋势及天气趋势开始图标，天气趋势结束图标。
2.	显示时钟:
以时钟的形式动态显示当前系统时间，时间精确到秒。
3.	火车票查询
依据用户选择的出发站、到达站、出发日期、车票类型等查询车票信息，并写入到本地数据库中，以备下次查询。
4.	通讯录
依据用户选择的校区、二级单位、部门等信息查询其电话，支持模糊查询。
用户可以自己输入校区、二级单位、部门、电话等信息，并将该条记录插入到本地数据库中。
5.	校园通知
用户选择查询时，依据用户选择的条件(日期、单位、类型)，从本地数据库中查询，支持模糊查询。
用户选择更新时，依据用户所选择的通知类型，单位，从指定网页上抓取最新通知，并写入数据库中，以供查询。
用户点击查询结果中的链接即可直接访问该通知页。
6.	发送邮件
用户在设定好端口号、主机地址、发件人、密码等后，可一次性输入多个收件人地址，实现一键多人发送邮件。
7.	用户管理
实现对当前系统中用户信息的查看、修改以及用户的删除功能。
用户可在登录界面处注册成为新用户。
8.	日志功能
日志文件中记录邮件发送日志以及异常日志。
9. 多语言
支持中文、英文两种语言，可随时切换，动态加载界面资源。
10. 更换皮肤
使用过程中可随时更换皮肤
11. 找回密码
   用户可通过注册时设置的密保问题以及密保答案，来重新设置密码。
12. 帮助功能
提供两种帮助方法:联机帮助(访问项目主页，获取在线帮助)
本地帮助文档(软件安装时自带的帮助文档)
13. 窗口置顶
支持将软件窗口始终置顶
14. 系统托盘
软件启动时，会在系统托盘区出现登录提示以及托盘图标。
## Demo
![QQ截图20190611232612](https://user-images.githubusercontent.com/25344334/59285302-58900400-8ca0-11e9-97c1-02ff4f1cf677.jpg)
![1ULZ%Z@Z QFR~AT8~RB3U~D](https://user-images.githubusercontent.com/25344334/59285419-883f0c00-8ca0-11e9-869f-38ff84b3d336.png)
## 设计文档
* [设计说明书](./doc/基于C%23爬虫的校园信息平台设计书.doc)
* [使用说明书](./doc/基于C%23爬虫的校园信息平台使用说明书.docx)