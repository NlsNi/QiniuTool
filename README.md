**练手项目**

## 七牛云存储上传工具

目前实现的功能：

- 选择文件并上传，将拼接的外链地址复制到剪贴板，带图片预览。
- 通过计算本地文件的MD5并与数据库中的信息进行比对来查看某个文件是否上传过，避免重复上传。
- 所有与账号相关的设置存储在`App.config`文件中，通过ConfigurationManager来进行读取。
- 支持选择bucket，如果未选择，则会使用默认的bucket。

因为windows UAC的限制，不考虑拖拽上传。

## MySQL支持

本地MySQL建表语句,数据库名称qiniu

```mysql
CREATE TABLE pictures (
  ID int(11) NOT NULL AUTO_INCREMENT,
  Bucket varchar(255) NOT NULL,
  HashValue varchar(255) NOT NULL,
  UploadTime datetime NOT NULL,
  DownloadUrl varchar(255) NOT NULL,
  LocalPath varchar(255) NOT NULL,
  Description varchar(255) DEFAULT NULL,
  PRIMARY KEY (ID)
) 

```

上传成功后后侧会更新数据库中的所有图片信息。

将数据库的连接字符串写入到app.config文件当中，利用Configurationmanager进行读取。

## 图片预览

当点击datagridview中的单元格时，会读取所在行的localPath值，然后载入该路径的本地图片。同时会将对应的图片外链地址更新至左侧外链地址文本框中，方便进行复制操作。改进了原来上传完图片才能查看所有上传图片的方式，现在双击datagridview即可浏览全部上传图片。

Todo List

- [x] 加入本地数据库存储图片外链信息
- [x] 可根据图片外链或者hash预览图片
- [x] 官方SDK改版了，考虑重写
- [ ] 加入设置选项
- [ ] 图片添加水印
- [ ] 界面优化
      ​



