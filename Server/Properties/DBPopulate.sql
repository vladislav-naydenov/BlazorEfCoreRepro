﻿SET IDENTITY_INSERT [dbo].[PhotoSessionInfo] ON 
GO
GO
SET IDENTITY_INSERT [dbo].[PhotoSessionInfo] OFF
GO

SET IDENTITY_INSERT [dbo].[PhotoSessionDetails] ON 
GO
INSERT [dbo].[PhotoSessionDetails] ([Id], [LanguageCode], [Type], [Description], [PhotoSessionInfoId]) VALUES (1, N'bg-BG', N'На открито', N'&lt;p&gt;&lt;b&gt;На открито &lt;/b&gt;&lt;u&gt;тест&lt;/u&gt;&lt;b&gt;&lt;/b&gt;&lt;br&gt;&lt;/p&gt;', 1)
GO
INSERT [dbo].[PhotoSessionDetails] ([Id], [LanguageCode], [Type], [Description], [PhotoSessionInfoId]) VALUES (2, N'en-GB', N'Outdoor', N'&lt;p&gt;&lt;b&gt;Outdoor&lt;/b&gt;&lt;br&gt;&lt;/p&gt;', 1)
GO
SET IDENTITY_INSERT [dbo].[PhotoSessionDetails] OFF
GO