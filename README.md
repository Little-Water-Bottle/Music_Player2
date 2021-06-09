音乐播放器 参考youtube上的视频做的加了一个登陆窗口，使用sqlserver数据库记录登陆账户。

数据库版本：SQL server2019

sql 脚本：

```
USE [音乐后台数据管理]
GO
/****** Object:  Table [dbo].[M_User]    Script Date: 2021/6/9 22:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_User](
	[ID] [varchar](20) NULL,
	[Uname] [varchar](20) NULL,
	[Upwd] [varchar](20) NULL
) ON [PRIMARY]
GO

```



步骤，将数据库脚本导入数据库，自行添加 ID Uname Upwd数据，Uname 和Upwd用于账号登陆。

此版修复了些许Bug，有下：

bug1 导入歌曲会播放音乐却不显示歌名
bug2 切歌时不更新歌名
bug3 添加歌曲时第二次新添时报错
bug4 右切歌时向上切改向下切

